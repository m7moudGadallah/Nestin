import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable,forkJoin } from 'rxjs';
import { map } from 'rxjs/operators';
import { Country } from '../../models/locationSearch/countries';
import { Property } from '../../models/listings/propertyApi';
import { Region } from '../../models/locationSearch/regions';
import { ApiResponse } from '../../models/ApiResponse';
@Injectable({
  providedIn: 'root',
})
export class LocationsService {
  private locationApi = 'https://localhost:7026/api/v1/Locations'
  private countryApi = 'https://localhost:7026/api/v1/Countries'
  private regionApi = 'https://localhost:7026/api/v1/Regions'
  private propertyApiUrl = 'https://localhost:7026/api/v1/Properties'
  constructor(private http : HttpClient){}

  // Search for locations, countries, and regions simultaneously
  // searchAll(query: string): Observable<any> {
  //   const params = new HttpParams().set('query', query);

  //   const locationRequest = this.http.get(this.locationApi, { params });
  //   const countryRequest = this.http.get(this.countryApi, { params });
  //   const regionRequest = this.http.get(this.regionApi, { params });

  //   return forkJoin([locationRequest, countryRequest, regionRequest]);
  // }
  searchAll(query: string): Observable<[any[], any[], any[]]> {
    return forkJoin([
      this.http.get<ApiResponse>(this.locationApi),
      this.http.get<ApiResponse>(this.countryApi),
      this.http.get<ApiResponse>(this.regionApi)
    ]).pipe(
      map(([locationsRes, countriesRes, regionsRes]) => {
        console.log('Raw response:', locationsRes, countriesRes, regionsRes); // for test

      const locations = Array.isArray(locationsRes.items) ? locationsRes.items:[];
      const countries = Array.isArray(countriesRes.items) ? countriesRes.items:[];
      const regions = Array.isArray(regionsRes.items) ? regionsRes.items:[];

      const filteredLocations = locations.filter((loc: { name: string; }) =>
        loc.name.toLowerCase().includes(query.toLowerCase())
      );
      const filteredCountries = countries.filter((country: { name: string; }) =>
        country.name.toLowerCase().includes(query.toLowerCase())
      );
      const filteredRegions = regions.filter((region: { name: string; }) =>
        region.name.toLowerCase().includes(query.toLowerCase())
      );

      return [filteredLocations, filteredCountries, filteredRegions];
      })
    );
  }
  





  // Search for properties by locationId, countryId, or regionId
  searchPropertiesByLocation(locationId?: number, countryId?: number, regionId?: number): Observable<any> {
    const params = new HttpParams()
    .set('locationId', locationId?.toString() || '')
    .set('countryId', countryId?.toString() || '')
    .set('regionId', regionId?.toString() || '');

  console.log("Requesting properties with params:", params.toString()); // ده هيساعدنا نعرف إذا كانت الـ params صح

  return this.http.get(this.propertyApiUrl, { params }).pipe(
    map(data => {
      console.log("API Response for properties:", data); // التأكد من الـ data اللي بترجع من الـ API
      return Array.isArray(data) ? data : [];
    })
  );
  }






















































  
}
