import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class LocationsService {
  private apiUrl = 'http://localhost:5050/country';
  constructor(private http: HttpClient) {}
  //for countries
  getAllCountries(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl);
  }
}
