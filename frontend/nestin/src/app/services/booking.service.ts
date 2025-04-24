import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Injectable } from '@angular/core';
import { ApiConstant } from '../utils/api-constant.util';
import { IBookingResponse } from '../models/api/response/ibooking-response';
import { IBookingRequest } from '../models/api/request/ibooking-req';

@Injectable({
  providedIn: 'root',
})
export class BookingService {
  constructor(private http: HttpClient) {}

  createBooking(bookingData: IBookingRequest): Observable<IBookingResponse> {
    return this.http.post<IBookingResponse>(
      `${ApiConstant.booking.createBooking}`,
      bookingData
    );
  }
}
