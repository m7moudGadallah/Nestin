import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { PropertyService } from '../../services/property.service';
import { IPropertyTypeRes } from '../../models/api/response/i-property-type-res';
import { HttpResponse, HttpErrorResponse } from '@angular/common/http';
import { IpropertyTypeApiResponse } from '../../models/api/response/iproperty-type-api-res';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { HostListener } from '@angular/core';
import { IPropertyWithDistance } from '../../models/domain/iproperty-with-distance';
import { Heart, LucideAngularModule } from 'lucide-angular';
import { ToastContainerComponent } from '../../components/toast-container/toast-container.component';
import { ToastService } from '../../services/toast.service'; // Adjust the path as needed

import {
  faHouse,
  faBed,
  faHotel,
  faSun,
  faSearch,
  faGlobe,
  faSliders,
  faStar,
  faStarHalfAlt,
  faTree,
  faUmbrellaBeach,
  faMountain,
  faTractor,
  faCity,
  faHeart,
} from '@fortawesome/free-solid-svg-icons';
import { IProperty } from '../../models/domain/iproperty';
import { IpropertyRes } from '../../models/api/response/iproperty-res';
import { Router } from '@angular/router';
import { FavoritePropertiesService } from '../../services/favorite-properties.service';
import { ISmartSearchReq } from '../../models/api/request/ismartSearch-req';
import { ISmartSearchRes } from '../../models/api/response/ismartSearch-res';

@Component({
  selector: 'app-home-page',
  standalone: true,
  imports: [CommonModule, FormsModule, FontAwesomeModule, LucideAngularModule],
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss'],
})
export class HomePageComponent {
  icon = {
    heart: Heart,
  };

  searchMode: 'simple' | 'advanced' = 'simple';
  guestMenuVisible: boolean = false;
  showFilters: boolean = false;
  selectedPropertyType: number | null = null;
  priceRange: number = 500;
  selectedRating: number = 4;
  propertyTypes: IPropertyTypeRes[] = [];
  property: IPropertyWithDistance[] = [];
  allProperties: IPropertyWithDistance[] = [];
  errorMessage: string = '';
  userLat: number = 30.033333;
  userLon: number = 31.233334;
  scrollY = 0;
  isFocused = false;
  LocationName: string = '';
  checkInDate: string = '';
  checkOutDate: string = '';
  guestsCount: any = null;
  minPrice: number = -1;
  maxPrice: number = -1;
  propertyRating: number = 0;
  propertyTypeId: number = -1;
  stringAiSearch: string | null = null;
  // pagination variables-----------------------------------
  currentPage: number = 1;
  itemsPerPage: number = 0;
  totalItems: number = 0;
  Math = Math;

  guests = {
    adults: 2,
    children: 0,
    infants: 0,
    pets: 0,
  };

  amenities = [
    { id: 1, name: 'Pool', selected: false },
    { id: 2, name: 'WiFi', selected: true },
    { id: 3, name: 'Kitchen', selected: false },
    { id: 4, name: 'Parking', selected: false },
    { id: 5, name: 'Air conditioning', selected: false },
  ];

  // Extended Font Awesome icons
  icons: { [key: string]: any } = {
    heart: faHeart,
    house: faHouse,
    'bed-single': faBed,
    hotel: faHotel,
    'sun-moon': faSun,
    globe: faGlobe,
    search: faSearch,
    sliders: faSliders,
    star: faStar,
    'star-half-alt': faStarHalfAlt,
    tree: faTree,
    'umbrella-beach': faUmbrellaBeach,
    mountain: faMountain,
    tractor: faTractor,
    city: faCity,
  };

  constructor(
    private propertyService: PropertyService,
    private route: Router,
    private favouriteService: FavoritePropertiesService,
    private toastService: ToastService
  ) {}

  ngOnInit(): void {
    this.getPropertyTypes();
    this.getAllProperty();
  }

  setSearchMode(mode: 'simple' | 'advanced'): void {
    this.searchMode = mode;
  }

  toggleGuestMenu(): void {
    this.guestMenuVisible = !this.guestMenuVisible;
  }

  @HostListener('window:scroll', ['$event'])
  onWindowScroll() {
    this.scrollY = window.scrollY;
  }

  toggleFilters(): void {
    this.showFilters = !this.showFilters;
  }

  selectPropertyType(id: number): void {
    this.selectedPropertyType = this.selectedPropertyType === id ? null : id;
  }

  getGuestSummary(): string {
    const parts = [];
    if (this.guests.adults > 0)
      parts.push(
        `${this.guests.adults} adult${this.guests.adults > 1 ? 's' : ''}`
      );
    if (this.guests.children > 0)
      parts.push(
        `${this.guests.children} child${this.guests.children > 1 ? 'ren' : ''}`
      );
    if (this.guests.infants > 0)
      parts.push(
        `${this.guests.infants} infant${this.guests.infants > 1 ? 's' : ''}`
      );
    if (this.guests.pets > 0)
      parts.push(`${this.guests.pets} pet${this.guests.pets > 1 ? 's' : ''}`);

    return parts.length > 0 ? parts.join(', ') : 'Add guests';
  }

  getPropertyTypes(): void {
    this.propertyService.showPropertyType().subscribe({
      next: (response: HttpResponse<IpropertyTypeApiResponse>) => {
        if (response.status === 200 && response.body) {
          this.propertyTypes = response.body.items;
        } else {
          this.handlePropertyerror('Invalid Loading Property Types');
        }
      },
      error: error => {
        console.error('Error fetching property types:', error);
        this.handlePropertyerror('Failed to load property types');
      },
    });
  }

  getAllProperty(): void {
    this.propertyService.getAllProperty().subscribe({
      next: (response: HttpResponse<IpropertyRes>) => {
        if (response.status === 200 && response.body) {
          this.property = response.body.items.map(prop => ({
            ...prop,
            distanceFromMe: this.getDistanceFromLatLonInKm(
              this.userLat,
              this.userLon,
              prop.latitude,
              prop.longitude
            ).toFixed(1),
          }));
          this.totalItems = response.body.metaData.total;
          this.itemsPerPage = response.body.metaData.pageSize;
          this.currentPage = response.body.metaData.page;
        } else {
          this.handlePropertyerror('Invalid Loading Property');
        }
      },
      error: error => {
        console.error('Error fetching property:', error);
        this.handlePropertyerror('Failed to load property');
      },
    });
  }

  handlePropertyerror(message: string): void {
    this.errorMessage = message;
  }

  // Helper method to get icon for property type
  getPropertyIcon(iconName: string): any {
    return this.icons[iconName] || this.icons['house']; // Default to house icon if not found
  }

  getDistanceFromLatLonInKm(
    lat1: number,
    lon1: number,
    lat2: number,
    lon2: number
  ): number {
    const R = 6371; // Radius of the earth in km
    const dLat = this.deg2rad(lat2 - lat1);
    const dLon = this.deg2rad(lon2 - lon1);
    const a =
      Math.sin(dLat / 2) * Math.sin(dLat / 2) +
      Math.cos(this.deg2rad(lat1)) *
        Math.cos(this.deg2rad(lat2)) *
        Math.sin(dLon / 2) *
        Math.sin(dLon / 2);
    const c = 2 * Math.atan2(Math.sqrt(a), Math.sqrt(1 - a));
    const d = R * c; // Distance in km
    return d;
  }

  deg2rad(deg: number): number {
    return deg * (Math.PI / 180);
  }

  getMarginTop() {
    if (this.searchMode === 'advanced' && this.showFilters) {
      return 250; // 250px if Advanced and showFilters is visible
    } else if (this.searchMode === 'advanced') {
      return 200; // 200px if Advanced and showFilters is not visible
    } else {
      return 100; // 100px if Simple search mode
    }
  }

  onFocus() {
    this.isFocused = true;
  }

  onBlur() {
    this.isFocused = false;
  }

  updatePageData(): void {
    const startIndex = (this.currentPage - 1) * this.itemsPerPage;
    const endIndex = startIndex + this.itemsPerPage;
    this.allProperties = this.property.slice(startIndex, endIndex);
  }

  onPageChange(pageNumber: number): void {
    this.currentPage = pageNumber;
    this.updatePageData();
  }

  navigateToProperty(propertyId: string): void {
    this.route.navigate(['/property', propertyId]);
  }

  searchProperties(): void {
    const queryParams: any = {};

    // Add location if it's available
    if (this.LocationName) {
      queryParams.LocationName = this.LocationName;
    }

    // Add checkInDate if it's available
    if (this.checkInDate) {
      queryParams.CheckIn = this.checkInDate;
    }

    // Add checkOutDate if it's available
    if (this.checkOutDate) {
      queryParams.CheckOut = this.checkOutDate;
    }

    // Add guestsCount if it's greater than 0
    if (this.guestsCount != null) {
      queryParams.GuestCount = this.guestsCount;
    }

    // Add price range
    if (this.minPrice >= 0) {
      queryParams.PriceMin = this.minPrice;
    }

    // Add maxPrice if it's greater than 0
    if (this.maxPrice > 0 && this.maxPrice > this.minPrice) {
      queryParams.PriceMax = this.maxPrice;
    }

    // Add propertyRating if it's greater than 0
    if (this.selectedRating > 0) {
      queryParams.MinAvgRating = this.selectedRating;
    }

    // Add propertyTypeId if it's greater than 0
    if (this.selectedPropertyType) {
      queryParams.PropertyTypeId = this.selectedPropertyType;
    }

    console.log('Query Params:', queryParams);
    console.log('Iam in search properties');
    this.propertyService.searchProperty(queryParams).subscribe({
      next: (response: HttpResponse<IpropertyRes>) => {
        if (response.status === 200 && response.body) {
          console.log(response.body.items);
          this.property = response.body.items.map(prop => ({
            ...prop,
            distanceFromMe: this.getDistanceFromLatLonInKm(
              this.userLat,
              this.userLon,
              prop.latitude,
              prop.longitude
            ).toFixed(1),
          }));
          this.totalItems = response.body.metaData.total;
          this.itemsPerPage = response.body.metaData.pageSize;
          this.currentPage = response.body.metaData.page;
        } else {
          this.handlePropertyerror('Invalid search result');
        }
      },
      error: error => {
        console.error('Search error:', error);
        this.handlePropertyerror('Failed to search properties');
      },
    });
  }

  SmartSearch(): void {
    if (this.stringAiSearch) {
      console.log('Smart Search:', this.stringAiSearch);
      this.propertyService.smartSearch(this.stringAiSearch).subscribe({
        next: (response: HttpResponse<ISmartSearchRes>) => {
          if (response.status === 200 && response.body) {
            console.log(response.body.items);
            this.property = response.body.items.map(prop => ({
              ...prop,
              distanceFromMe: this.getDistanceFromLatLonInKm(
                this.userLat,
                this.userLon,
                prop.latitude,
                prop.longitude
              ).toFixed(1),
            }));
          } else {
            this.handlePropertyerror('Invalid Smart Search result');
          }
        },
        error: error => {
          console.error('Error during Smart Search:', error);
          this.handlePropertyerror('Failed to search properties');
        },
      });
    }
  }

  addToFav(propertyId: string): void {
    this.favouriteService.addToFavorites(propertyId).subscribe({
      next: response => {
        this.toastService.showSuccess('Property added to favorites.');
      },
      error: error => {
        if (error.status === 409) {
          // If the property has already been added to favorites
          this.toastService.showError(
            'You already added this property to your favorites before.'
          );
        } else {
          console.error('Failed to add to favorites:', error);
          this.toastService.showError(
            'Failed to add to favorites. Please try again.'
          );
        }
      },
    });
  }
}
