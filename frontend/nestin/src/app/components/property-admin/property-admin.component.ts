import { Component, OnInit } from '@angular/core';
import { NavigationEnd, Router, RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { PropertyService } from '../../services/property.service';
import { IPropertyTypeRes } from '../../models/api/response/i-property-type-res';
import { HttpResponse } from '@angular/common/http';
import { IpropertyTypeApiResponse } from '../../models/api/response/iproperty-type-api-res';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';
import { HostListener } from '@angular/core';
import { IPropertyWithDistance } from '../../models/domain/iproperty-with-distance';
import { IProperty } from '../../models/domain/iproperty';
import { IpropertyRes } from '../../models/api/response/iproperty-res';
import {
  faChevronLeft,
  faChevronRight,
  faTrash,
  faThumbtack,
  faCheck,
  faTimes,
} from '@fortawesome/free-solid-svg-icons';

@Component({
  selector: 'app-property-admin',
  imports: [CommonModule, FormsModule, RouterModule, FontAwesomeModule],
  templateUrl: './property-admin.component.html',
  styleUrl: './property-admin.component.scss',
})
export class PropertyAdminComponent implements OnInit {
  searchMode: 'simple' | 'advanced' = 'simple';
  showFilters: boolean = false;
  property: IPropertyWithDistance[] = [];
  allProperties: IPropertyWithDistance[] = [];
  errorMessage: string = '';
  userLat: number = 30.033333;
  userLon: number = 31.233334;
  currentPage: number = 1;
  itemsPerPage: number = 10;
  totalItems: number = this.property?.length || 0;
  Math = Math;

  icons: { [key: string]: any } = {
    'chevron-left': faChevronLeft,
    'chevron-right': faChevronRight,
    trash: faTrash,
    pin: faThumbtack,
    check: faCheck,
    times: faTimes,
  };
  constructor(
    private propertyService: PropertyService,
    private route: Router
  ) {}
  ngOnInit(): void {
    this.getAllProperty();
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
          console.log(this.property);
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
  updatePageData(): void {
    // const startIndex = (this.currentPage - 1) * this.itemsPerPage;
    // const endIndex = startIndex + this.itemsPerPage;
    // this.allProperties = this.property.slice(startIndex, endIndex);
    if (this.itemsPerPage <= 0) {
      this.itemsPerPage = 10; // Set a default value
    }
    const startIndex = (this.currentPage - 1) * this.itemsPerPage;
    const endIndex = startIndex + this.itemsPerPage;
    this.allProperties = this.property.slice(startIndex, endIndex);
  }
  onPageChange(pageNumber: number): void {
    this.currentPage = pageNumber;
    this.updatePageData();
  }

  //======================================================================
  onDelete(propertyId: string): void {
    console.log('Delete property with ID:', propertyId);
  }

  onPin(propertyId: string): void {
    console.log('Pin property with ID:', propertyId);
  }

  toggleActive(property: IPropertyWithDistance): void {
    property.isActive = !property.isActive;
    console.log(
      'Toggle active for property:',
      property.id,
      'Now:',
      property.isActive
    );
  }
}
