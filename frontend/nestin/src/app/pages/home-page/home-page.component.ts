import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { PropertyService } from '../../services/property.service';
import { IPropertyTypeRes } from '../../models/api/response/i-property-type-res';
import { HttpResponse } from '@angular/common/http';
import { IpropertyTypeApiResponse } from '../../models/api/response/iproperty-type-api-response';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
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
} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-home-page',
  standalone: true,
  imports: [CommonModule, FormsModule, FontAwesomeModule],
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.scss',
})
export class HomePageComponent {
  searchMode: 'simple' | 'advanced' = 'simple';
  guestMenuVisible: boolean = false;
  showFilters: boolean = false;
  selectedPropertyType: number | null = null;
  priceRange: number = 500;
  selectedRating: number = 4;
  propertyTypes: IPropertyTypeRes[] = [];
  errorMessage: string = '';

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

  constructor(private propertyService: PropertyService) {}

  ngOnInit(): void {
    this.getPropertyTypes();
  }

  setSearchMode(mode: 'simple' | 'advanced'): void {
    this.searchMode = mode;
  }

  toggleGuestMenu(): void {
    this.guestMenuVisible = !this.guestMenuVisible;
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

  handlePropertyerror(message: string): void {
    this.errorMessage = message;
  }

  // Helper method to get icon for property type
  getPropertyIcon(iconName: string): any {
    return this.icons[iconName] || this.icons['house']; // Default to house icon if not found
  }
}
