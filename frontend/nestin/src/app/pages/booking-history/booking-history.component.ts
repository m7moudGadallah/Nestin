import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Bookings, GetBookingsResponse } from '../../models/api/request/iget-bookings';
import { CheckOutBookingService } from '../../services/check-out-booking.service';
import { HttpErrorResponse, HttpResponse } from '@angular/common/http';
import { IRole } from '../../models/domain/iuser-role';

@Component({
  selector: 'app-booking-history',
  imports: [CommonModule,FormsModule],
  templateUrl: './booking-history.component.html',
  styleUrl: './booking-history.component.scss'
})
export class BookingHistoryComponent implements OnInit{
  bookings: Bookings[] = [];
  selectedStatus: string = 'all';
  selectedFilter: string = 'checkIn-desc';
  searchQuery: string = '';
  filteredBookingsSearch : Bookings[] = [];
  userRole: string | undefined;

  constructor(private checkOutService:CheckOutBookingService){}
  ngOnInit(): void {
    this.loadBookings();
    this.loadUserProfile();
  }
  loadBookings(): void {
    this.checkOutService.getAllBookings().subscribe({
      next: (response: HttpResponse<GetBookingsResponse>) => { 
        this.bookings = response?.body?.items || []; 
        console.log(response,'no response')
        if (this.bookings.length === 0) {
          console.warn('Received empty bookings array');
        }
      },
      error: (err: HttpErrorResponse) => {
        console.error('Booking load error:', err);
        this.bookings = [];  // Clear previous data
        
        let errorMessage = 'Failed to load bookings';
        if (err.status === 0) {
          errorMessage += ' (Network error - is backend running?)';
        } else {
          errorMessage += ` (Server error: ${err.status})`;
        }
        
        alert(errorMessage);
      }
    });
  }
  loadUserProfile():void{
   this.checkOutService.getUserRole().subscribe({
    next: (response: HttpResponse<IRole>) => { 
      this.userRole = response?.body?.name|| undefined; 
      console.log(response,'no role')
      // if (this.bookings.length === 0) {
      //   console.warn('Received empty bookings array');
      // }
    },
    error: (err: HttpErrorResponse) => {
      console.error('Role load error:', err);
      // this.bookings = [];  // Clear previous data
      
      // let errorMessage = 'Failed to load bookings';
      // if (err.status === 0) {
      //   errorMessage += ' (Network error - is backend running?)';
      // } else {
      //   errorMessage += ` (Server error: ${err.status})`;
      // }
      
      // alert(errorMessage);
    }
  });
  
  }
  
 
  get firstGuestCount(): number | null {
    return this.bookings?.[0]?.bookingGuests?.[0]?.guestCount ?? null;
  }
  //getter for filteration
  get filteredBookings(): Bookings[] {
    if (this.selectedStatus === 'all') {
      return this.bookings;
    }
    return this.bookings.filter(booking => booking?.status === this.selectedStatus);
  }
  //ordering filteration 
 
applySort(): void {
  if (!this.filteredBookings) return;

  switch (this.selectedFilter) {
    case 'checkIn-desc':
      this.filteredBookings.sort((a, b) => new Date(b.checkIn).getTime() - new Date(a.checkIn).getTime());
      break;
    case 'checkIn-asc':
      this.filteredBookings.sort((a, b) => new Date(a.checkIn).getTime() - new Date(b.checkIn).getTime());
      break;
    case 'price-asc':
      this.filteredBookings.sort((a, b) => a.pricePerNight - b.pricePerNight);
      break;
    case 'price-desc':
      this.filteredBookings.sort((a, b) => b.pricePerNight - a.pricePerNight);
      break;
    default:
      break;
  }
}
  //search============================
  searchBookings(): void {
    this.bookings = this.bookings.filter((booking) => {
      const matchesQuery =
        booking?.property?.title.toLowerCase().includes(this.searchQuery.toLowerCase()) ||
        booking?.property?.location?.name.toLowerCase().includes(this.searchQuery.toLowerCase()) ||
        booking?.property?.owner.userName.toLowerCase().includes(this.searchQuery.toLowerCase());

  
      return matchesQuery;
    });
  }
  
  calculateNumberOfNights(checkIn: string | undefined, checkOut: string | undefined): number | null {

    if (!checkIn || !checkOut) {
      return null; 
    }
  
    const checkInDate = new Date(checkIn);
    const checkOutDate = new Date(checkOut);
  
    
    const differenceInTime = checkOutDate.getTime() - checkInDate.getTime();
  
  
    const numberOfNights = differenceInTime / (1000 * 3600 * 24); // 1000ms * 3600s * 24h
    return numberOfNights;
  }
  // to calculate total price (price per night * number pf nights)
calculateTotalPrice(pricePerNight: number | undefined, checkIn: string | undefined, checkOut: string | undefined): number | null {
  if (pricePerNight === undefined) {
    return null; 
  }
  const numberOfNights = this.calculateNumberOfNights(checkIn, checkOut);

  if (numberOfNights === null) {
    return null; 
  }

  return pricePerNight * numberOfNights; 
}
// to calculate total price
calculateTotal(pricePerNight: number | undefined, checkIn: string | undefined, checkOut: string | undefined, totalFees: number | undefined): number | null {
 
  if (pricePerNight === undefined || totalFees === undefined) {
    return null; 
  }
  const numberOfNights = this.calculateNumberOfNights(checkIn, checkOut);
  if (numberOfNights === null) {
    return null; 
  }
  const totalPrice = pricePerNight * numberOfNights;
  return totalPrice + totalFees; 
}
//filteration based on userId 

}
