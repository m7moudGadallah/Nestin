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
  faGlobe
} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-home-page',
  standalone: true,
  imports: [
    CommonModule,
    FormsModule,
    FontAwesomeModule
  ],
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.scss',
})
export class HomePageComponent {
  guestMenuVisible: boolean = false;
  propertyTypes: IPropertyTypeRes[] = [];
  errorMessage: string = '';

  // Font Awesome icons
  icons: { [key: string]: any } = {
    house: faHouse,
    'bed-single': faBed,
    hotel: faHotel,
    'sun-moon': faSun,
    globe: faGlobe,
    search: faSearch,
  };

  constructor(private propertyService: PropertyService) {}

  ngOnInit(): void {
    this.getPropertyTypes();
  }

  toggleGuestMenu(): void {
    this.guestMenuVisible = !this.guestMenuVisible;
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
      error: (error) => {
        console.error('Error fetching property types:', error);
        this.handlePropertyerror('Failed to load property types');
      }
    });
  }

  handlePropertyerror(message: string): void {
    this.errorMessage = message;
  }
}
