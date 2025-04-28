import { Injectable } from '@angular/core';
import { HttpClient , HttpHeaders, HttpResponse} from '@angular/common/http';
import { catchError, map, Observable, throwError } from 'rxjs';
import { ApiConstant } from '../utils/api-constant.util';
import { GetBookingsResponse } from '../models/api/request/iget-bookings';
import { PropertyDetails } from '../models/api/request/iget-propertiesDetails';
import { IProperty } from '../models/domain/iproperty';

@Injectable({
  providedIn: 'root'
})
export class CheckOutBookingService {
  
  private checkoutApi = 'https://localhost:7026/api/v1/Bookings/checkout';
  constructor( private http : HttpClient) { }

  getAllBookings(): Observable<HttpResponse<any>> {
    return this.http.get<any>(ApiConstant.booking.getAllBookings, { observe:'response', withCredentials: true })
}
  createBooking(bookingData: any): Observable<any> {
    return this.http.post(ApiConstant.booking.createBooking, bookingData, { withCredentials: true });
  }
  getPropertyDetails(id: string):Observable<PropertyDetails>{
    return this.http.get<PropertyDetails>(`${ApiConstant.PropertiesApi.getAll}/${id}`)
  }  
  getAllProperties(): Observable<{ items: IProperty [] }> {
    return this.http.get<{ items: IProperty [] }>(`${ApiConstant.baseUrl}/Properties`);
  }
  checkOut(body: any, headers: HttpHeaders): Observable<any> {
    return this.http.post<any>(this.checkoutApi, body, { headers: headers, withCredentials: true });
  }
  getUserRole():Observable<HttpResponse<any>>{
    return this.http.get<any>('https://localhost:7026/api/v1/UserProfiles/me',{ observe:'response', withCredentials: true});
  }
  
}
