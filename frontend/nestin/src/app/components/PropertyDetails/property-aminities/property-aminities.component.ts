import { Component, Input, OnInit } from '@angular/core';
import { IPropertyInfo } from '../../../models/domain/iproperty-info';
import { IPropertyAmenity } from '../../../models/domain/iproperty-amenity';
import { PropertyService } from '../../../services/property.service';
import { CommonModule, JsonPipe } from '@angular/common';
import { IAminityCategory } from '../../../models/domain/IAminity-category';
import { forkJoin } from 'rxjs';
import { IPropertyAmenityRes } from '../../../models/api/response/iproperty-amenity-res';
import { ActivatedRoute } from '@angular/router';
import { LucideAngularModule, Sparkles, icons } from 'lucide-angular';
import { EventEmitter, Output } from '@angular/core';


import {
  LucideWifi,
  LucideTv,
  LucideTwitch,
  LucideParkingCircle,
  LucideWaves,
} from 'lucide-angular';

@Component({
  selector: 'app-property-aminities',
  imports: [CommonModule, JsonPipe, LucideAngularModule],
  templateUrl: './property-aminities.component.html',
  styleUrl: './property-aminities.component.css',
})
export class PropertyAminitiesComponent implements OnInit {
  
  icons = {
    sparkles: Sparkles,
  };
  // icons = {
  //   wifi: LucideWifi,
  //   tv: LucideTv,
  //   kitchen: LucideTwitch,
  //   parking: LucideParkingCircle,
  //   waves: LucideWaves,

  // };

  @Input() propertyId!: string;


  // State variables
  isModalOpen = false;
  amenities: IPropertyAmenity[] = [];
  categories: IAminityCategory[] = [];
  isLoading = true;
  showAll = false;
  error = false;

  // Display constants
  readonly PREVIEW_AMENITIES_COUNT = 6;

  constructor(
    private propertyService: PropertyService,
    private route: ActivatedRoute
  ) {}

  ngOnInit() {
    this.propertyId = this.route.snapshot.paramMap.get('id') || '';
  
    this.loadAmenitiesData();
  }

  // loadAmenitiesData() {
  //   this.isLoading = true;
  //   this.error = false;

  //   forkJoin({
  //     propertyAmenities: this.propertyService.getAmenitiesByPropertyId(this.propertyId),
  //     allAmenities: this.propertyService.getAllAmenities(),
  //     categories: this.propertyService.getAmenityCategories()
  //   }).subscribe({
  //     next: ({ propertyAmenities, allAmenities, categories }) => {
  //       try {
  //         console.log('API Responses:', { propertyAmenities, allAmenities, categories });

  //         // this.categories = categories as unknown as IAminityCategory[];
  //         this.categories = Array.isArray(categories) ? categories : [];

  //         // Get all amenity IDs for this property
  //         const propertyAmenityIds = new Set(
  //           (propertyAmenities as unknown as IPropertyAmenityItem[]).map(pa => pa.amenity.id)
  //         );

  //         // Create a map of all amenities for quick lookup
  //         const allAmenitiesMap = new Map<string, IPropertyAmenity>();
  //         (allAmenities as unknown as IPropertyAmenity[]).forEach(amenity => {
  //           allAmenitiesMap.set(amenity.id.toString(), amenity);
  //         });

  //         // Filter and merge amenities
  //         this.amenities = Array.from(propertyAmenityIds)
  //           .map(id => allAmenitiesMap.get(id.toString()))
  //           .filter((amenity): amenity is IPropertyAmenity => amenity !== undefined);

  //         this.isLoading = false;
  //       } catch (error) {
  //         console.error('Error processing amenities data:', error);
  //         this.error = true;
  //         this.isLoading = false;
  //       }
  //     },
  //     error: (err) => {
  //       console.error('Error loading amenities:', err);
  //       this.error = true;
  //       this.isLoading = false;
  //     }
  //   });
  // }

    loadAmenitiesData() {
    this.isLoading = true;
    this.error = false;

    forkJoin({
      propertyAmenities: this.propertyService.getPropertyAmenitiesById(
        this.propertyId
      ),
      allAmenities: this.propertyService.getAllAmenities(),
      categories: this.propertyService.getAmenitiesCategories(),
    }).subscribe({
      next: ({ propertyAmenities, allAmenities, categories }) => {
        try {
          // console.log('Raw API Responses:', {
          //   propertyAmenities,
          //   allAmenities,
          //   categories,
          // });

          this.categories =
            this.extractItemsArray<IAminityCategory>(categories);
          console.log('Processed categories:', this.categories);

          const propertyAmenitiesArray =
          propertyAmenities.body.items.map((am: IPropertyAmenity) => am.amenity.name);
         // console.log('Property amenities:', propertyAmenitiesArray);

          const allAmenitiesArray =
           propertyAmenities.body.items.map((am: IPropertyAmenity) => am.amenity.name);
          console.log('All amenities:From PropertyAmenties', allAmenitiesArray);
          this.amenities =allAmenitiesArray

          // const allAmenitiesMap = new Map<string, IPropertyAmenity>();
          //   allAmenitiesArray.forEach((amenity: IPropertyAmenity) => {
          //   if (amenity?.amenity.id) {
          //     allAmenitiesMap.set(amenity.amenity.id.toString(), amenity);
          //   }
          //   });

        //     const propertyAmenityNames: string[] = propertyAmenitiesArray
            

        // console.log(propertyAmenityNames,'NAMESSSSSSSSSSSSSSSSS'); // This will log the array of amenity names
        //  // console.log('Property amenity IDs:', propertyAmenityIds);

         

         console.log('Final amenities list:', this.amenities);

          this.isLoading = false;
        } catch (error) {
          //console.error('Error processing amenities data:', error);
          this.error = true;
          this.isLoading = false;
        }
      },
      error: err => {
        console.error('Error loading amenities:', err);
        this.error = true;
        this.isLoading = false;
      },
    });
  }

  private extractItemsArray<T>(data: any): T[] {
    if (Array.isArray(data)) {
      return data;
    }
    if (data && typeof data === 'object' && Array.isArray(data.items)) {
      return data.items;
    }
    return [];
  }

  getTopAmenities(): IPropertyAmenity[] {
    return this.amenities.slice(0, this.PREVIEW_AMENITIES_COUNT);
  }

  getGroupedAmenities(): {
    categoryName: string;
    amenities: IPropertyAmenity[];
  }[] {
    if (!this.amenities.length || !this.categories.length) return [];

    const categoryMap = new Map<string, string>();
    this.categories.forEach(category => {
      if (category?.id && category?.name) {
        categoryMap.set(category.id.toString(), category.name);
      }
    });

    const grouped = this.amenities.reduce(
      (acc, amenity) => {
        if (!amenity?.amenity.categoryId) return acc;

        const categoryId = amenity.amenity.categoryId.toString();
        const categoryName = categoryMap.get(categoryId) || 'Other Amenities'; // Better fallback

        if (!acc[categoryName]) {
          acc[categoryName] = [];
        }

        if (amenity.amenity.name && typeof amenity.amenity.name === 'string') {
          acc[categoryName].push(amenity);
        }

        return acc;
      },
      {} as Record<string, IPropertyAmenity[]>
    );

    return Object.entries(grouped)
      .map(([categoryName, amenities]) => ({
        categoryName,
        amenities: amenities.sort((a, b) =>
          (a.amenity.name || '').localeCompare(b.amenity.name || '')
        ),
      }))
      .sort((a, b) => a.categoryName.localeCompare(b.categoryName));
  }

  toggleShowAll() {
    this.showAll = !this.showAll;
  }

  openModal() {
    this.isModalOpen = true;
    document.body.style.overflow = 'hidden';
  }

  closeModal() {
    this.isModalOpen = false;
    document.body.style.overflow = '';
  }
}
