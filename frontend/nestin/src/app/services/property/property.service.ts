import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, forkJoin, of } from 'rxjs';
import { map, switchMap } from 'rxjs/operators';
import { Property } from '../../models/listings/property.model';

@Injectable({
  providedIn: 'root'
})
export class PropertyService {

  constructor(private http : HttpClient) { }
  getPropertywithImage(): Observable<Property[]> {
    return this.http.get<Property[]>('http://localhost:3000/property').pipe(
      switchMap((properties) => {
        const requests = properties.map(prop => {
          return this.http.get<any[]>(`http://localhost:3000/propertyImage?properyID=${prop.id}`).pipe(
            switchMap((propImages) => {
              const imageId = propImages[0].imageId;
              return this.http.get<any>(`http://localhost:3000/images/${imageId}`).pipe(
                map(image => ({
                  ...prop,
                  imageUrl: image.name
                }))
              );
            })
          );
        });
  
        return forkJoin(requests);
      })
    );
  }
  
}
