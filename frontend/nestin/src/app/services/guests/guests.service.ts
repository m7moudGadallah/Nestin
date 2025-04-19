import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class GuestsService {

  constructor(private http : HttpClient) { }
  getGuestsInfo(propertyId: string): Observable<any> {
    const url = `https://localhost:7026/api/v1/Properties/${propertyId}/Guests`;
    return this.http.get<any>(url);
  }
}
