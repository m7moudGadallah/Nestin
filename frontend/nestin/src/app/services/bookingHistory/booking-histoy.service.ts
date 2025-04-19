import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BookingHistoyService {
  private apiUrl = 'https://localhost:7026/api/v1/Bookings';

  constructor(private http : HttpClient) { }
  getBookings(): Observable<any> {
    return this.http.get<any[]>(this.apiUrl);
  }

  cancelBooking(bookingId: number): Observable<void> {
    return this.http.delete<void>(`${this.apiUrl}/${bookingId}`);
  }
}
