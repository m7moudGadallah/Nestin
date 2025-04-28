import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { CheckOutBookingService } from '../../services/check-out-booking.service';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpHeaders, HttpResponse } from '@angular/common/http';
import { Bookings, GetBookingsResponse } from '../../models/api/request/iget-bookings';
import { PropertyDetails } from '../../models/api/request/iget-propertiesDetails';


@Component({
  selector: 'app-booking-page',
  imports: [CommonModule,FormsModule],
  templateUrl: './booking-page.component.html',
  styleUrl: './booking-page.component.scss'
})
export class BookingPageComponent implements OnInit{
  //overlay
  isOverlayOpen = false; 
  overlayType: 'guest' | 'date' | null = null; 
  checkInDate: string = ''; 
  checkOutDate: string = ''; 
  savedCheckIn: string = ''; 
  savedCheckOut: string = '';
  adults=1;
  children=0;
  infants=0;
  pets=0;
  savedAdults=1;
  savedChildren=0;
  savedInfants=0;
  savedPets=0;

  openOverlay(type: 'guest' | 'date'): void {
    // this.isOverlayOpen = true;
    this.overlayType = type;
    //dates
    this.checkInDate = this.savedCheckIn;
    this.checkOutDate = this.savedCheckOut;
    //guests
    this.adults=this.savedAdults;
    this.children=this.savedChildren;
    this.infants=this.savedInfants;
    this.pets=this.savedPets;
  }
  //add guests
  increment(type:string):void{
    if(type==='adults'){
      this.adults++
    } else if (type === 'children') {
      this.children++
    } else if (type === 'infants'){
      this.infants++
    } else if ( type === 'pets'){
      this.pets++
    }
  }
   // decrease guests number
   decrement(type:string):void{
    if(type === 'adults' && this.adults > 1){
      this.adults--;
    } else if (type === 'children' && this.children > 0){
      this.children--;
    }else if (type === 'infants' && this.infants > 0){
      this.infants--;
    }else if (type === 'pets' && this.pets > 0){
      this.pets--;
    }
  }
  closeOverlay(): void {
    // this.isOverlayOpen = false;7
    this.overlayType = null;
  }
  saveChanges(): void {
    //dates
    this.savedCheckIn = this.checkInDate;
    this.savedCheckOut = this.checkOutDate;
    //guests
    this.savedAdults = this.adults;
    this.savedChildren = this.children;
    this.savedInfants = this.infants;
    this.savedPets = this.pets;

    this.closeOverlay();
  } 
  get totalGuests(): string{
    const total = this.savedAdults + this.savedChildren + this.savedInfants + this.pets;
    if (total === 0) return 'Add guests';
    return `${total} guest${total > 1 ? 's' : ''}`;
  }

  //----------------------------------Api Integration----------------------------------------------------------
  bookingId : string;
  constructor (
                private checkOutService:CheckOutBookingService,
                private route:ActivatedRoute,
                private router : Router
  ){
    this.bookingId = this.route.snapshot.paramMap.get('id')!;
  }

  bookings: Bookings[] = [];
  propertyDetails: PropertyDetails | null=null;
  propertyId: string = '';
  selectedBookingId: string = '';
  ngOnInit(): void {
    this.loadBookings();
    this.loadAllProperties();
  }
  loadBookings(): void {
    this.checkOutService.getAllBookings().subscribe({
      next: (response:HttpResponse<GetBookingsResponse>) => {
        console.log('Bookings:', response?.body?.items);
        if (response?.body?.items && response.body.items.length > 0) {
          this.bookings = response.body.items;
          this.selectedBookingId = this.bookings[0]?.id || '';
        } else {
          console.error('No bookings found');
        }
      },
      error: (err) => {
        console.error('Error loading bookings', err);
        alert('Failed to load bookings, please try again');
      }
    });
  }
  loadAllProperties(): void {
    this.checkOutService.getAllProperties().subscribe({
      next: (response) => {
        const properties = response.items; 
        if (properties.length > 0) {
          this.propertyId = properties[0].id; 
          this.loadPropertyDetails(this.propertyId); 
        }
      },
      error: (err) => {
        console.error('Error loading properties', err);
        alert('Failed to load properties');
      }
    });
  }
  loadPropertyDetails(propertyId: string) {
    this.checkOutService.getPropertyDetails(propertyId).subscribe({
      next: (response) => {
        this.propertyDetails = response;
        console.log('Property Details:', this.propertyDetails);
      },
      error: (err) => {
        console.error('Error loading property details', err);
      }
    });
  }
  
  onCheckOut() {
    const token = localStorage.getItem('accessToken');
  
    if (!token) {
      console.error('Access token is missing');
      alert('You must be logged in to checkout.');
      return;
    }
    if (!this.selectedBookingId) {
      console.error('Booking ID is missing');
      alert('Please select a booking before proceeding to checkout.');
      return;
    }
  
    const headers = new HttpHeaders({
      'Authorization': `Bearer ${token}`,
      'Content-Type': 'application/json'
    });
  
    const body = { bookingId: this.selectedBookingId };
  
    this.checkOutService.checkOut(body, headers).subscribe({
      next: (response) => {
        console.log('Checkout successful', response);
  
        const sessionId = response.items[0]?.sessionId;
        const sessionUrl = response.items[0]?.sessionUrl;
  
        if (!sessionId || !sessionUrl) {
          console.error('Session ID or URL is missing from response');
          alert('Invalid checkout session, please try again');
          return;
        }
  
        
        window.location.href = sessionUrl;
      },
      error: (err) => {
        console.error('Checkout failed', err);
        alert('Failed to proceed to checkout, please try again');
      }
    });
  }
  get hasBookingWithPhotos(): boolean {
    return (
      this.bookings &&
      this.bookings.length > 0 &&
      this.bookings[0] &&
      this.bookings[0].property &&
      this.bookings[0].property.photos &&
      this.bookings[0].property.photos.length > 0
    );
  }
  get firstBookingPhotoUrl(): string {
    return this.bookings?.[0]?.property?.photos?.[0]?.photoUrl;
  }
  get firstGuestCount(): number | null {
    return this.bookings?.[0]?.bookingGuests?.[0]?.guestCount ?? null;
  }
  
  // calculate nights function

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
createBooking() {
  if (!this.checkInDate || !this.checkOutDate) {
    alert('Please select both check-in and check-out dates.');
    return;
  }

  const bookingData = {
    checkIn: this.checkInDate,
    checkOut: this.checkOutDate,
   
  };

  this.checkOutService.createBooking(bookingData).subscribe({
    next: (response) => {
      console.log('Booking created successfully:', response);
      alert('Booking created successfully!');
    },
    error: (err) => {
      console.error('Error creating booking:', err);
      alert('Failed to create booking.');
    }
  });
}


}
