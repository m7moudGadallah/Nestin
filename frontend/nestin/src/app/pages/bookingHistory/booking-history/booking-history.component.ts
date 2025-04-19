import { Component,OnInit } from '@angular/core';
import { BookingHistoyService } from '../../../services/bookingHistory/booking-histoy.service';

@Component({
  selector: 'app-booking-history',
  imports: [],
  templateUrl: './booking-history.component.html',
  styleUrl: './booking-history.component.css'
})
export class BookingHistoryComponent implements OnInit{
  activeTab: string = 'active';
  activeBookings = [];
  pastBookings = [];

  constructor(private bookingHistoryService: BookingHistoyService) {}

  ngOnInit(): void {
    this.loadBookings();
  }
  setActiveTab(tab: string) {
    this.activeTab = tab;
  }
  loadBookings() {
    this.bookingHistoryService.getBookings().subscribe(data => {
      this.activeBookings = data.filter((booking: { status: string; }) => booking.status === 'Confirmed');
      this.pastBookings = data.filter((booking: { status: string; }) => booking.status === 'Completed');
    });
  }
  cancelBooking(bookingId: number) {
    this.bookingHistoryService.cancelBooking(bookingId).subscribe(() => {
      this.loadBookings(); // Reload after cancellation
    });
  }
}
