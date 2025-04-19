import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
//import { Property } from '../../models/listings/property';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BookingService {
  private apiUrl = 'https://localhost:7026/api/v1/Properties'
  constructor(private http : HttpClient) { }
  getBookingDetailsbyID(id:string):Observable<any>{
    return this.http.get(`${this.apiUrl}/${id}`)
  }
  //to get property fees 
  getPropertyFees(propertyId: string): Observable<any> {
    return this.http.get(`https://localhost:7026/api/v1/Properties/${propertyId}/Fees`);
  }
  
}
