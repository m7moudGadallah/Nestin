import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, forkJoin, of } from 'rxjs';
import { map, switchMap, tap } from 'rxjs/operators';
import { Property } from '../../models/listings/propertyApi';

@Injectable({
  providedIn: 'root',
})
export class PropertyService {
  constructor(private http: HttpClient) {}
  private propertyApiUrl = 'https://localhost:7026/api/v1/properties';
  //get property with image 
  getPropertywithImage(): Observable<Property[]> {
    return this.http.get<any>(this.propertyApiUrl).pipe(
      tap((res: any) => console.log('API Response:', res)), // دي هتطبع شكل الريسبونس
      map(res => {
        const properties = res.items ?? []; // لو فيه data يبقى خدها، لو لأ يبقى الريسبونس نفسه
        return properties.map((prop: any) => ({
          ...prop,
          imageUrl: prop.photos[0]?.photoUrl 
        }));
      })
    );
  }
}

