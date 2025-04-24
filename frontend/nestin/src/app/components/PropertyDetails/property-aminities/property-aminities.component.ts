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
  //

  // @Input() property!: IPropertyInfo;
  // isModalOpen = false;
  // amenities: IPropertyAmenity[] = [];
  // isLoading = true;

  // ngOnInit() {
  //   this.loadAmenity();
  // }

  // loadAmenity() {
  //   if (this.property?.amenities) {
  //     this.amenities = this.property.amenities.map(item => item.amenity);
  //     this.isLoading=true;
  //   } else {
  //     this.amenities = [];
  //     this.isLoading = false;
  //   }

  // }

  // getTopAmenities(): IPropertyAmenity[] {
  //   return this.amenities.slice(0, 6) || [];
  // }

  // getGroupedAmenities(): { name: string, amenities: IPropertyAmenity[] }[] {
  //   if (!this.property.amenities) return [];

  //   // Group amenities by their categoryId
  //   const amenitiesByCategory = this.property.amenities.reduce((acc, amenity) => {
  //     const categoryKey = `category_${amenity.categoryId}`;
  //     if (!acc[categoryKey]) {
  //       acc[categoryKey] = [];
  //     }
  //     acc[categoryKey].push(amenity);
  //     return acc;
  //   }, {} as Record<string, IPropertyAmenity[]>);

  //   // Convert to array format
  //   return Object.entries(amenitiesByCategory).map(([categoryKey, amenities]) => ({
  //     name: `Category ${categoryKey.split('_')[1]}`, // Default category name
  //     amenities
  //   }));
  // }

  // getGroupedAmenities(): { name: string, amenities: IPropertyAmenity[] }[] {
  //   if (!this.amenities || this.amenities.length === 0) return [];

  //   // Group amenities by their categoryId
  //   const amenitiesByCategory = this.amenities.reduce((acc, amenity) => {
  //     const categoryKey = `category_${amenity.categoryId}`;
  //     if (!acc[categoryKey]) {
  //       acc[categoryKey] = [];
  //     }
  //     acc[categoryKey].push(amenity);
  //     return acc;
  //   }, {} as Record<string, IPropertyAmenity[]>);

  //   // Convert to array format
  //   return Object.entries(amenitiesByCategory).map(([categoryKey, amenities]) => ({
  //     name: `Category ${categoryKey.split('_')[1]}`,
  //     amenities
  //   }));
  // }

  // openModal() {
  //   this.isModalOpen = true;
  //   document.body.style.overflow = 'hidden';
  // }

  // closeModal() {
  //   this.isModalOpen = false;
  //   document.body.style.overflow = '';
  // }
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
    console.log('Property ID:', this.propertyId);
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
          console.log('Raw API Responses:', {
            propertyAmenities,
            allAmenities,
            categories,
          });

          this.categories =
            this.extractItemsArray<IAminityCategory>(categories);
          console.log('Processed categories:', this.categories);

          const propertyAmenitiesArray =
            this.extractItemsArray<IPropertyAmenityRes>(propertyAmenities);
          console.log('Property amenities:', propertyAmenitiesArray);

          const allAmenitiesArray =
            this.extractItemsArray<IPropertyAmenity>(allAmenities);
          console.log('All amenities:', allAmenitiesArray);

          const allAmenitiesMap = new Map<string, IPropertyAmenity>();
          allAmenitiesArray.forEach(amenity => {
            if (amenity?.amenity.id) {
              allAmenitiesMap.set(amenity.amenity.id.toString(), amenity);
            }
          });

          const propertyAmenityIds = new Set(
            propertyAmenitiesArray
              .flatMap(pa =>
                pa.items.map(amenity => amenity.amenity.id.toString())
              )
              .filter(Boolean)
          );
          console.log('Property amenity IDs:', propertyAmenityIds);

          this.amenities = Array.from(propertyAmenityIds)
            .map(id => allAmenitiesMap.get(id))
            .filter((amenity): amenity is IPropertyAmenity => !!amenity);

          console.log('Final amenities list:', this.amenities);

          this.isLoading = false;
        } catch (error) {
          console.error('Error processing amenities data:', error);
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
