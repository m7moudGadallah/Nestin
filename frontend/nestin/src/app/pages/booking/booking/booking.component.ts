import { Component,HostListener,OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { BookingService } from '../../../services/bookingReservation/booking.service';
import { ActivatedRoute } from '@angular/router';
import { BookingResponse,Booking } from '../../../models/bookings/bookings';
import { Property } from '../../../models/listings/propertyApi';

@Component({
  selector: 'app-booking',
  imports: [FormsModule,CommonModule],
  templateUrl: './booking.component.html',
  styleUrl: './booking.component.css',
})
export class BookingComponent implements OnInit {
  constructor(private bookingService:BookingService, private route: ActivatedRoute){}

  bookings: Booking[]=[];
  property :Property | null = null;

  ngOnInit(): void {
    this.loadBookings();
  }
  
  loadBookings(){
    this.bookingService.getBookings().subscribe({
      next: (response: BookingResponse) => {
        this.bookings = response.items;
  
        if (this.bookings.length > 0) {
          this.loadProperty(this.bookings[0].property.id); 
        }
      },
      error: (err) => console.error('error fetching data', err)
    })
  }
  loadProperty(propertyId: string) {
    this.bookingService.getBookingDetailsbyID(propertyId).subscribe({
      next: (property) => {
        this.property = property;
      },
      error: (err) => console.error('Error fetching property:', err)
    });
  }
  







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
}
