import {
  Component,
  ElementRef,
  HostListener,
  OnInit,
  ViewChild,
} from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { PropertyService } from '../../services/property/property.service';
import { CategoriesService } from '../../services/categories/categories.service';
import { Category } from '../../models/categories/category';
import { Property } from '../../models/listings/propertyApi';
import { CommonModule } from '@angular/common';
import {LucideAngularModule,Heart} from 'lucide-angular'

@Component({
  selector: 'app-home',
  imports: [CommonModule,LucideAngularModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css',
})
export class HomeComponent implements OnInit {
  //lucide icon 
  icons = {
    wishlist:Heart,
  }
  //pagination variables-----------------------------------
  currentPage: number = 1;
  itemsPerPage: number = 8; 
  totalItems: number = 0;

  //---------------------------pagination-------------------------------------



  //category filteration 
  selectedPropertyTypeId: number | null = null;
  allProperties: Property[] = []; // دي كل الداتا الأصلية
  
  filterProperties() {
    if (this.selectedPropertyTypeId) {
      this.properties = this.allProperties.filter(prop => prop.propertyType.id === this.selectedPropertyTypeId);
    } else {
      this.properties = this.allProperties;
    }
  }

  onSelectCategory(typeId: number) {
  this.selectedPropertyTypeId = typeId;
  this.filterProperties();
  }

  filterByCategory(propertyTypeId: number) {
    this.selectedPropertyTypeId = propertyTypeId;
    this.properties = this.allProperties.filter(
      prop => prop.propertyType.id === propertyTypeId
    );
  }
  
  
  //for categories arrow scroll
  @ViewChild('categoriesContainer') categoriesContainer!: ElementRef;

  scrollLeft() {
    this.categoriesContainer.nativeElement.scrollBy({
    left: -200,
    behavior: 'smooth'
  });
  }

scrollRight() {
  this.categoriesContainer.nativeElement.scrollBy({
    left: 200,
    behavior: 'smooth'
  });
}

  //for display property in cards
  properties: Property[] = [];
  categories: Category[] = [];
  ngOnInit(): void {
    //to get all categories
    this.categoryService.getCategories().subscribe({
      next:(data) => {
        this.categories = data;
      },
      error:(err) => {
        console.error('error fetching categories',err)
      }
    });
    //for properties
    this.fetchProperties();
    
    const userLat = 30.033333;
    const userLon = 31.233334;

    this.propertyService.getPropertywithImage().subscribe(data => {
      this.allProperties = data.map(prop => ({
        ...prop,
        distanceFromMe: this.getDistanceFromLatLonInKm(
          userLat,
          userLon,
          prop.latitude,
          prop.longitude
        ).toFixed(1),
      }));
      // فلترة حسب النوع لو متحدد
  if (this.selectedPropertyTypeId) {
    this.properties = this.allProperties.filter(
      prop => prop.propertyType.id === this.selectedPropertyTypeId
    );
  } else {
    this.properties = this.allProperties;
  }
    });
  }
  fetchProperties() {
    this.propertyService.getPropertywithImage().subscribe({
      next: (data: Property[]) => {
        this.properties = data; 
        this.totalItems = data.length;
        this.updatePageData();
        console.log('Fetched Properties:', this.properties); // for testing 
      },
      error: (error) => {
        console.error('Error fetching properties:', error);
      },
      complete: () => {
        console.log('Property fetching completed.');
      }
    });
      
  }
  updatePageData(): void {
    const startIndex = (this.currentPage - 1) * this.itemsPerPage;
    const endIndex = startIndex + this.itemsPerPage;
    this.properties = this.allProperties.slice(startIndex, endIndex);
  }
  onPageChange(pageNumber: number): void {
    this.currentPage = pageNumber;
    this.updatePageData();
  }
  getDistanceFromLatLonInKm(
    lat1: number,
    lon1: number,
    lat2: number,
    lon2: number
  ): number {
    const R = 6371;
    const dLat = this.deg2rad(lat2 - lat1);
    const dLon = this.deg2rad(lon2 - lon1);
    const a =
      Math.sin(dLat / 2) * Math.sin(dLat / 2) +
      Math.cos(this.deg2rad(lat1)) *
        Math.cos(this.deg2rad(lat2)) *
        Math.sin(dLon / 2) *
        Math.sin(dLon / 2);
    const c = 2 * Math.atan2(Math.sqrt(a), Math.sqrt(1 - a));
    return R * c;
  }
  deg2rad(deg: number): number {
    return deg * (Math.PI / 180);
  }
  //route map button--------------------------------------------------
  currentRoute: string = '';
  buttonText: string = 'Show Map';
  constructor(
    private router: Router,
    private propertyService: PropertyService,
    private categoryService: CategoriesService
  ) {
    this.router.events.subscribe(event => {
      if (event instanceof NavigationEnd) {
        this.currentRoute = event.urlAfterRedirects;

        // نغير النص حسب الصفحة
        if (this.currentRoute === '/map') {
          this.buttonText = 'Show Listings';
        } else {
          this.buttonText = 'Show Map';
        }
      }
    });
  }
  toggleView() {
    if (this.currentRoute === '/map') {
      this.router.navigate(['/']); // بيرجعني للهوم
    } else {
      this.router.navigate(['/map']); // يوديني للماب
    }
  }
  

}
