import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ApiConstant } from '../utils/api-constant.util';
import { IPropertyTypeRes } from '../models/api/response/i-property-type-res';
import { IpropertyTypeApiResponse } from '../models/api/response/iproperty-type-api-res';

@Injectable({
  providedIn: 'root',
})
export class PropertyService {
  constructor(private http: HttpClient) {}

  showPropertyType(): Observable<HttpResponse<IpropertyTypeApiResponse>> {
    return this.http.get<IpropertyTypeApiResponse>(
      `${ApiConstant.PropertiesApi.getAllPropertyTypes}`,
      {
        observe: 'response',
        withCredentials: true,
      }
    );
  }
  getAllProperty(): Observable<HttpResponse<any>> {
    return this.http.get<any>(`${ApiConstant.PropertiesApi.getAll}`, {
      observe: 'response',
      withCredentials: true,
    });
  }
  searchProperty(params: any): Observable<HttpResponse<any>> {
    return this.http.get<any>(`${ApiConstant.PropertiesApi.getAll}`, {
      params: params,
      observe: 'response',
      withCredentials: true,
    });
  }
  
  getPropertyById(id: string): Observable<HttpResponse<any>> {
    const url = ApiConstant.PropertiesApi.getById.replace('{id}', id);
    return this.http.get<any>(url, {
      observe: 'response',
      withCredentials: true,
    });
  }
  getPropertyAmenitiesById(id: string): Observable<HttpResponse<any>> {
    const url = ApiConstant.PropertiesApi.getPropertyAmenities.replace(
      '{id}',
      id
    );
    return this.http.get<any>(url, {
      observe: 'response',
      withCredentials: true,
    });
  }

  getPropertyAvailabilityById(id: string): Observable<HttpResponse<any>> {
    const url = ApiConstant.PropertiesApi.getPropertyAvailability.replace(
      '{id}',
      id
    );
    return this.http.get<any>(url, {
      observe: 'response',
      withCredentials: true,
    });
  }

  getPropertyFeesById(id: string): Observable<HttpResponse<any>> {
    const url = ApiConstant.PropertiesApi.getPropertyFees.replace('{id}', id);
    return this.http.get<any>(url, {
      observe: 'response',
      withCredentials: true,
    });
  }

  getAllAmenities(): Observable<HttpResponse<any>> {
    return this.http.get<any>(`${ApiConstant.AmenitiesApi.getAllAmenities}`, {
      observe: 'response',
      withCredentials: true,
    });
  }

  getAmenitiesCategories(): Observable<HttpResponse<any>> {
    return this.http.get<any>(
      `${ApiConstant.AmenitiesApi.getAllAmenitiesCategories}`,
      {
        observe: 'response',
        withCredentials: true,
      }
    );
  }
}
