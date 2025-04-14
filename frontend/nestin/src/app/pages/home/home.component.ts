import { Component,ElementRef,HostListener,OnInit, ViewChild } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { PropertyService } from '../../services/property/property.service';
import { CategoriesService } from '../../services/categories/categories.service';
import { Category } from '../../models/categories/category';
import { Property } from '../../models/listings/property.model';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-home',
  imports: [CommonModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css',
})
export class HomeComponent implements OnInit{
  //for display property in cards
  properties : Property[] = [];
  categories: Category[] = [];
  ngOnInit(): void {
    //to get all categories
    this.categoryService.getCategories().subscribe((data:Category[]) => {
      this.categories = data;

    })
    //for properties
    const userLat = 30.033333;
    const userLon = 31.233334;

    this.propertyService.getPropertywithImage().subscribe(data => {
      this.properties = data.map(prop => ({
        ...prop,
        distanceFromMe: this.getDistanceFromLatLonInKm(userLat, userLon, prop.latitude, prop.longitude).toFixed(1)
      }));
    });
  }
  getDistanceFromLatLonInKm(lat1: number, lon1: number, lat2: number, lon2: number): number {
    const R = 6371;
    const dLat = this.deg2rad(lat2 - lat1);
    const dLon = this.deg2rad(lon2 - lon1);
    const a =
      Math.sin(dLat / 2) * Math.sin(dLat / 2) +
      Math.cos(this.deg2rad(lat1)) * Math.cos(this.deg2rad(lat2)) *
      Math.sin(dLon / 2) * Math.sin(dLon / 2);
    const c = 2 * Math.atan2(Math.sqrt(a), Math.sqrt(1 - a));
    return R * c;
  }
  deg2rad(deg: number): number {
    return deg * (Math.PI / 180);
  }
  //route map button
  currentRoute: string = '';
  buttonText: string = 'Show Map';
  constructor(private router: Router,private propertyService:PropertyService, private categoryService : CategoriesService) {
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
  //for map button
  @ViewChild('footerElement') footerElement!: ElementRef;
isFooterVisible = false;

@HostListener('window:scroll', [])
onScroll(): void {
  if (this.footerElement) {
    const footerRect = this.footerElement.nativeElement.getBoundingClientRect();
    this.isFooterVisible = footerRect.top < window.innerHeight;
  }
}
  // filterByCategory(categoryId: number) {
  //   this.propertyService.getPropertywithImage().subscribe((allProps) => {
  //     this.properties = allProps.filter(p => p.typeId === categoryId);
  //   });
  // }
}
