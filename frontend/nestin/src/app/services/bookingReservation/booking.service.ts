import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
//import { Property } from '../../models/listings/property';
import { Observable } from 'rxjs';
import { BookingResponse } from '../../models/bookings/bookings';

@Injectable({
  providedIn: 'root'
})
export class BookingService {
  private propertyUrl = 'https://localhost:7026/api/v1/Properties';
  private bookingHistory = 'https://localhost:7026/api/v1/Bookings'
  constructor(private http : HttpClient) { }
  
  getBookings():Observable<BookingResponse>{
    return this.http.get<BookingResponse>(this.propertyUrl);
  }
  getBookingDetailsbyID(id:string):Observable<any>{
    return this.http.get(`${this.propertyUrl}/${id}`)
  }
  
  
}
