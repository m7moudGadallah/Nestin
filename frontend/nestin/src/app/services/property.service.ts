import { Injectable } from '@angular/core';
import {
  HttpClient,
  HttpResponse,
  HttpHeaders,
  HttpParams,
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { ApiConstant } from '../utils/api-constant.util';
import { IPropertyTypeRes } from '../models/api/response/i-property-type-res';
import { IpropertyTypeApiResponse } from '../models/api/response/iproperty-type-api-res';
import { ISmartSearchReq } from '../models/api/request/ismartSearch-req';
import { ISmartSearchRes } from '../models/api/response/ismartSearch-res';
import { IGetAllReq } from '../models/api/request/iget-all-req';

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
  getAllProperty(queryParams?: IGetAllReq): Observable<HttpResponse<any>> {
    // Create HttpParams object from the query parameters
    let params = new HttpParams();

    if (queryParams) {
      // Add each query parameter to the HttpParams object
      Object.keys(queryParams).forEach(key => {
        const value = queryParams?.[key as keyof IGetAllReq];
        if (value !== undefined && value !== null) {
          params = params.append(key, value.toString());
        }
      });
    }
    return this.http.get<any>(`${ApiConstant.PropertiesApi.getAll}`, {
      observe: 'response',
      withCredentials: true,
      params
    });
  }
  searchProperty(params: any): Observable<HttpResponse<any>> {
    return this.http.get<any>(`${ApiConstant.PropertiesApi.getAll}`, {
      params: params,
      observe: 'response',
      withCredentials: true,
    });
  }

  smartSearch(query: string): Observable<HttpResponse<any>> {
    return this.http.post(
      `${ApiConstant.PropertiesApi.smartSearch}`,
      JSON.stringify(query),
      {
        observe: 'response',
        withCredentials: true,
        headers: new HttpHeaders({
          'Content-Type': 'application/json', // <- stay as application/json
          Accept: 'application/json',
        }),
      }
    );
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
