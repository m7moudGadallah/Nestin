import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { IPropertyInfo } from '../models/domain/iproperty-info';
import { IPropertyRequest } from '../models/api/request/iproperty-request';
import { ApiConstant } from '../utils/api-constant.util';

@Injectable({
  providedIn: 'root'
})
export class AddPropertyService {

  private apiUrl = 'api/properties'; 

  constructor(private http: HttpClient) { }

  addProperty(property: IPropertyRequest): Observable<IPropertyRequest> {
    return this.http.post<IPropertyRequest>(ApiConstant.PropertiesApi.getAll,
      property,
      { withCredentials: true });
  }

  
}
