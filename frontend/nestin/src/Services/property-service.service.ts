import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, forkJoin, map, switchMap, tap } from 'rxjs';
import { IProperty } from '../Models/iproperty';
import { IPropertyImage } from '../Models/iproperty-image';
import { IReview } from '../Models/ireview';
import { Iuser } from '../Models/iuser';
import { IPropertyAmenity } from '../Models/iproperty-amenity';
import { IPropertyInfo } from '../Models/iproperty-info';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class PropertyService {
  private propertyDataUrl = 'properties/propertyInfo.json';
  private imageDataUrl = 'images/property-images.json';
  private reviewDataUrl = 'properties/review.json';
  private userDataUrl = 'properties/user.json';
  private amenityDataUrl = 'properties/aminity.json';

  constructor(private http: HttpClient,private router: Router) {}
  navigateToProperty(propertyId: string) {
    this.router.navigate(['/properties', propertyId]);
  }

  // property.service.ts
getPropertyDetails(id: string): Observable<{ 
  propertyData: IPropertyInfo; 
  propertyImages: IPropertyImage[] 
}> {
  return forkJoin({
    property: this.getPropertyById(id),
    images: this.getImagesForProperty(id),
    reviews: this.getReviewsForProperty(id)
  }).pipe(
    switchMap(({property, images, reviews}) => {
      return forkJoin({
        host: this.getUserById(property.host.id),
        amenities: this.getAmenitiesForProperty(id)
      }).pipe(
        map(({host, amenities}) => ({
          propertyData: {
            ...property,
            amenities,
            reviews,
            host,
            averageRating: 8.5,
            reviewount: reviews.length
          },
          propertyImages: images
        }))
      );
    })
  );
}
  // getPropertyDetails(id: string): Observable<any> {
  //   return this.http.get<any>('properties/propertyInfo.json').pipe(
  //     map(data => {
  //       console.log('Raw JSON data:', data);
  //       return {
  //         propertyData: data,
  //         propertyImages: []
  //       };
  //     })
  //   );
  // }

  // getPropertyDetails(id: string): Observable<{ propertyData: IPropertyInfo; propertyImages: IPropertyImage[] }> {
  //   return this.http.get<{ propertyData: IPropertyInfo; propertyImages: IPropertyImage[] }>(
  //     `properties/propertyInfo.json/${id}`
  //   );
  // }

  private getPropertyById(id: string): Observable<IPropertyInfo> {
    console.log('Fetching property with ID:', id);
    
    return this.http.get<IPropertyInfo[]>(this.propertyDataUrl).pipe(
      tap(data => console.log('Raw property data:', data)),
      map(properties => {
        const property = properties.find(p => p.id.toString() === id);
        console.log('Found property:', property);
        
        if (!property) {
          throw new Error(`Property ${id} not found`);
        }
        return property;
      })
    );
  }

  private getImagesForProperty(propertyId: string): Observable<IPropertyImage[]> {
  return this.http.get<IPropertyImage[]>(this.imageDataUrl).pipe(
    map(images => images
      .filter(img => img.propertyId === propertyId)
      .sort((a, b) => new Date(b.touchedAt).getTime() - new Date(a.touchedAt).getTime())
    )
  );
  }

  private getReviewsForProperty(propertyId: string): Observable<IReview[]> {
    return this.http.get<IReview[]>(this.reviewDataUrl).pipe(
      map(reviews => reviews.filter(r => r.propertyId === propertyId))
    );
  }

  private getUserById(userId: string): Observable<Iuser> {
    return this.http.get<Iuser[]>(this.userDataUrl).pipe(
      map(users => {
        const user = users.find(u => u.id === userId);
        if (!user) {
          throw new Error('User not found');
        }
        return user;
      })
    );
  }

  private getAmenitiesForProperty(propertyId: string): Observable<IPropertyAmenity[]> {
    return forkJoin({
      propertyAmenities: this.http.get<any[]>(`properties/aminity.json`).pipe(
        map(pas => pas.filter(pa => pa.property_id === propertyId))
      ),
      allAmenities: this.http.get<any[]>(this.amenityDataUrl)
    }).pipe(
      map(({propertyAmenities, allAmenities}) => {
        return propertyAmenities.map(pa => {
          const amenity = allAmenities.find(a => a.id === pa.amenity_id);
          return {
            ...pa,
            ...amenity
          };
        });
      })
    );
  }
}