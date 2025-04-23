import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ApiConstant } from '../utils/api-constant.util';
import { IpropertyTypeApiResponse } from '../models/api/response/iproperty-type-api-response';

@Injectable({
  providedIn: 'root',
})
export class PropertyService {
  constructor(private http: HttpClient) {}

  showPropertyType(): Observable<HttpResponse<IpropertyTypeApiResponse>> {
    return this.http.get<any>(
      `${ApiConstant.PropertiesApi.getAllPropertyTypes}`,
      {
        observe: 'response',
        withCredentials: true,
      }
    );
  }
}
