import { Component,OnInit } from '@angular/core';
import { BookingHistoyService } from '../../../services/bookingHistory/booking-histoy.service';
import { Booking, BookingResponse } from '../../../models/bookings/bookings';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-booking-history',
  imports: [CommonModule],
  templateUrl: './booking-history.component.html',
  styleUrl: './booking-history.component.css'
})
export class BookingHistoryComponent implements OnInit{
 allBookings:Booking[]=[];
 filteredBookings :Booking[]=[];
 statusOptions:('confirmed' | 'pending' | 'cancelled')[] = ['pending', 'confirmed', 'cancelled'];
 selectedStatus:'confirmed' | 'pending' | 'cancelled' = 'pending'; //default

  constructor(private bookingHistoryService: BookingHistoyService) {}
  ngOnInit() {
    this.bookingHistoryService.getBookings().subscribe({
      next: (res) => {
        this.allBookings = res.items;
        this.filterByStatus(this.selectedStatus);
      },
      error: (err) => console.error('Error fetching bookings:', err)
    });
  }
  filterByStatus(status: 'confirmed' | 'pending' | 'cancelled') {
    this.selectedStatus = status;
    console.log('Selected Status:', this.selectedStatus); //for test 
    this.filteredBookings = this.allBookings.filter(b => b.status === status);

    console.log('Filtered Bookings:', this.filteredBookings);
  }
  // onStatusChange(status: string) {
  //   this.selectedStatus = status;
  //   this.filteredBookings = this.allBookings.filter(b => b.status === status);
  // }
  getGuestTypeName(guestTypeId: number): string {
    switch (guestTypeId) {
      case 1:
        return 'Adult';
      case 2:
        return 'Child';
      case 3:
        return 'Infant';
      default:
        return 'Unknown';
    }
  }  
  
}
