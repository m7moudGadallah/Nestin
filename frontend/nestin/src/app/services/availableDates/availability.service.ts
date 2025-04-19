import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AvailabilityService {

  constructor(private http : HttpClient) { }
  getAvailableProperties(checkIn: string, checkOut: string,propertyId:string): Observable<any[]>{
    const params = new HttpParams()
    .set('checkIn', checkIn)
    .set('checkOut', checkOut);
    const url = `https://localhost:7026/api/v1/Properties/${propertyId}/Availabilities`;
    return this.http.get<any[]>(url, { params });

  }
}
