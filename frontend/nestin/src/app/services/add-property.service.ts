import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { IPropertyInfo } from '../models/domain/iproperty-info';

@Injectable({
  providedIn: 'root'
})
export class AddPropertyService {

  private apiUrl = 'api/properties'; 

  constructor(private http: HttpClient) { }

  createProperty(property: Partial<IPropertyInfo>, photos: File[]): Observable<IPropertyInfo> {
    const formData = new FormData();
    
    // Append property data as JSON
    formData.append('property', JSON.stringify(property));
    
    // Append each photo file
    photos.forEach((file, index) => {
      formData.append(`photos`, file, file.name);
    });
    
    return this.http.post<IPropertyInfo>(this.apiUrl, formData);
  }
  
}
