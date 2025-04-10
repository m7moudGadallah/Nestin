import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IPropertyImage } from '../Models/iproperty-image';
import { map, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PropertyImageService {
  private imageDataUrl = '/images/property-images.json';
  constructor(private http: HttpClient) {}

  getImagesForProperty(propertyId: string): Observable<IPropertyImage[]> {
    return this.http.get<IPropertyImage[]>(this.imageDataUrl).pipe(
      map(images =>
        images
          .filter(img => img.property_id === propertyId)
          .sort((a, b) => new Date(b.touched_at).getTime() - new Date(a.touched_at).getTime())
      )      
    );
  }
}


