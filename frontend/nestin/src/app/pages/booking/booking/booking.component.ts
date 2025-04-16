import { Component,HostListener } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-booking',
  imports: [FormsModule,CommonModule],
  templateUrl: './booking.component.html',
  styleUrl: './booking.component.css',
})
export class BookingComponent {
  //overlay
  isOverlayOpen = false; 
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

  
  openOverlay(): void {
    this.isOverlayOpen = true;
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
    this.isOverlayOpen = false;
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
