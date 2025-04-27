import { Component, Input, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { IPropertyInfo } from '../../../models/domain/iproperty-info';
import { PropertyService } from '../../../services/property.service';
import { IBookingResponse } from '../../../models/api/response/ibooking-response';
import { IBookingRequest } from '../../../models/api/request/ibooking-req';
import { IPropertyFees } from '../../../models/domain/iproperty-fees';
import { BookingService } from '../../../services/booking.service';
import { IBookingSendingRequest } from '../../../models/api/request/ibooking-sending-req';

@Component({
  selector: 'app-booking-card',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './booking-card.component.html',
  styleUrls: ['./booking-card.component.css'],
})
export class BookingCardComponent implements OnInit {
  @Input({ required: true }) property!: IPropertyInfo;

  constructor(
    private propertyService: PropertyService,
    private bookingService: BookingService
  ) {}
  ngOnInit(): void {
    this.loadFees(this.property.id);
  }

  checkInDate: string = '';
  checkOutDate: string = '';
  guests: number = 1;
  selectedGuestType: number = 1;
  bookingData: IBookingSendingRequest = {
    propertyId: '',
    checkIn: '',
    checkOut: '',
    guests: []
  };
  get today(): string {
    return new Date().toISOString().split('T')[0];
  }

  get guestOptions(): number[] {
    const max = Math.min(this.property.maxGuestCount || 10, 16);
    return Array.from({ length: max }, (_, i) => i + 1);
  }

  get nights(): number {
    if (!this.checkInDate || !this.checkOutDate) return 0;
    const diff =
      new Date(this.checkOutDate).getTime() -
      new Date(this.checkInDate).getTime();
    return Math.ceil(diff / (1000 * 60 * 60 * 24));
  }

  // Price calculations
  // get cleaningFee(): number {
  //   return this.property.cleaningFee || 50;
  // }

  // get cleaningFee(): number {
  //   return   50;
  // }

  //  get serviceFee(): number {
  //     return this.subtotal * (this.property.serviceFeePercentage || 0.14);
  //   }

  // get serviceFee(): number {
  //   return this.subtotal * (0.14);
  // }

  get subtotal(): number {
    return this.nights * (this.property.pricePerNight || 0);
  }

  get total(): number {
    return this.subtotal + this.cleaningFee + this.serviceFee;
  }

  // handleBookNow() {
  //   console.log('Booking request:', {
  //     propertyId: this.property.id,
  //     checkIn: this.checkInDate,
  //     checkOut: this.checkOutDate,
  //     guests: this.guests,
  //     guestType: this.selectedGuestType,
  //     total: this.total
  //   });
  // }

  // ======================================Guest selection state=====================================
  showGuestModal = false;
  guestCounts = {
    adults: 1,
    children: 0,
    infants: 0,
    pets: 0,
  };

  get totalGuests(): number {
    return this.guestCounts.adults + this.guestCounts.children;
  }

  get guestSummary(): string {
    let parts = [];
    if (this.guestCounts.adults > 0) {
      parts.push(
        `${this.guestCounts.adults} ${this.guestCounts.adults === 1 ? 'adult' : 'adults'}`
      );
    }
    if (this.guestCounts.children > 0) {
      parts.push(
        `${this.guestCounts.children} ${this.guestCounts.children === 1 ? 'child' : 'children'}`
      );
    }
    if (this.guestCounts.infants > 0) {
      parts.push(
        `${this.guestCounts.infants} ${this.guestCounts.infants === 1 ? 'infant' : 'infants'}`
      );
    }
    if (this.guestCounts.pets > 0) {
      parts.push(
        `${this.guestCounts.pets} ${this.guestCounts.pets === 1 ? 'pet' : 'pets'}`
      );
    }
    return parts.join(', ') || 'Add guests';
  }

  decrementGuestCount(type: keyof typeof this.guestCounts, min: number): void {
    this.guestCounts[type] = Math.max(min, this.guestCounts[type] - 1);
  }

  //==========================fees======================================
  cleaningFee: number = 0;
  serviceFee: number = 0;
  extraGuestFee: number = 0;
  petFee: number = 0;

  loadFees(propertyId: string) {
    this.propertyService.getPropertyFeesById(propertyId).subscribe({
      next: response => {
        (response.body.items as IPropertyFees[]).forEach(fee => {
          switch (fee.name.toLowerCase()) {
            case 'cleaning fee':
              this.cleaningFee = fee.amount;
              break;
            case 'service fee':
              this.serviceFee = fee.amount;
              break;
            case 'extra guest fee':
              this.extraGuestFee = fee.amount;
              break;
            case 'pet fee':
              this.petFee = fee.amount;
              break;
          }

          console.log(
            `fees${(this.cleaningFee, this.serviceFee, this.extraGuestFee, this.petFee)}`
          );
        });
      },
      error: err => {
        console.error('Error loading fees:', err);
      },
    });
  }
  // =============================booking reservation=================================
  isBooking: boolean = false;
  bookingError: string | null = null;

  handleBookNow(): void {
    if (!this.checkInDate || !this.checkOutDate) return;
  
    this.isBooking = true;
    this.bookingError = null;
  
    this.bookingData = {
      propertyId: this.property.id,
      checkIn: this.checkInDate,
      checkOut: this.checkOutDate,
      guests: [
        { guestTypeId: 1, guestCount: this.guestCounts.adults },
        { guestTypeId: 2, guestCount: this.guestCounts.children },
        { guestTypeId: 3, guestCount: this.guestCounts.infants },
        { guestTypeId: 4, guestCount: this.guestCounts.pets },
      ].filter(guest => guest.guestCount > 0),
    };
  
    console.log('Booking data:', this.bookingData);
  
    this.bookingService.createBooking(this.bookingData).subscribe({
      next: (response: any) => {
        this.isBooking = false;
        console.log('Booking successful:', response);
  
        const statusCode = response.status;
  
        if (statusCode === 201) {
          alert('Booking created!');
        }
      },
      error: error => {
        this.isBooking = false;
  
        const statusCode = error.status;
        console.error('Booking failed:', error);
  
        if (statusCode === 409) {
          alert(error.error);
        } else if (statusCode === 401) {
          alert('Unauthorized. Please login.');
        } else {
          alert('Booking failed. Please try again.');
        }
      },
    });
  }
  
}
