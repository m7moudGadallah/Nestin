import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, RouterOutlet } from '@angular/router';

import L, { latLng, tileLayer, marker, icon } from 'leaflet';
import { Icon } from 'leaflet';
import { Lightbox } from 'ngx-lightbox';
import { CommonModule, JsonPipe } from '@angular/common';
import { LucideAngularModule } from 'lucide-angular';
import { LightboxModule } from 'ngx-lightbox';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { IPropertyImage } from '../../Models/iproperty-image';
import { PropertyService } from '../../Services/property-service.service';
import { Iuser } from '../../Models/iuser';
import { IPropertyAmenity } from '../../Models/iproperty-amenity';
import { IReview } from '../../Models/ireview';
import { IPropertyInfo} from '../../Models/iproperty-info';

@Component({
  selector: 'app-property-info',
  standalone: true,
  imports: [CommonModule, LucideAngularModule, LightboxModule, HttpClientModule,FormsModule,RouterOutlet,JsonPipe],
  templateUrl: './property-info.component.html',
  styleUrls: ['./property-info.component.css']
})
export class PropertyInfoComponent implements OnInit {
  property: IPropertyInfo ={} as IPropertyInfo;
  propertyImages: IPropertyImage[] = [];
  aminaties:IPropertyAmenity[] = [];
  reviews:IReview[] = [];
  host:Iuser | null = null;
  loading = true;
  error = false;
  lightboxImages: any[] = [];

  // Booking form
  checkInDate: string | null = null;
  checkOutDate: string | null = null;
  guests = 1;

  // Leaflet map
  mapOptions: any;
  mapMarkers: any[] = [];

  constructor(
    private route: ActivatedRoute,
    private propertyService: PropertyService,
    private lightbox: Lightbox
  ) {}

  ngOnInit(): void {
    this.fixLeafletAssets();
    this.route.paramMap.subscribe(params => {
      const propertyId = params.get('id');
      console.log('🚀 Route param ID:', propertyId);
    });
    
    // if (propertyId) {
    //   this.loadProperty(propertyId);
    // } else {
    //   this.error = true;
    //   this.loading = false;
    // }
    this.loadProperty("1");
    
    // this.getMap();
  }

  private fixLeafletAssets() {
    delete (Icon.Default.prototype as any)._getIconUrl;
    Icon.Default.mergeOptions({
      iconRetinaUrl: 'assets/marker-icon-2x.png',
      iconUrl: 'assets/marker-icon.png',
      shadowUrl: 'assets/marker-shadow.png'
    });
  }

 // property-info.component.ts
loadProperty(id: string): void {
  this.loading = true;
  this.error = false;

  console.log('Starting load for ID:', id);
  
  this.propertyService.getPropertyDetails(id).subscribe({
    next: (response) => {
      console.log('Full response:', response);
      
      // Add null checks
      if (!response?.propertyData) {
        console.error('Invalid response structure');
        this.error = true;
        this.loading = false;
        return;
      }

      this.property = response.propertyData;
      this.propertyImages = response.propertyImages || [];
      
      console.log('Loaded property:', this.property);
      console.log('Loaded images:', this.propertyImages);
      
      this.prepareLightboxImages();
      this.getMap();
      this.loading = false;
    },
    error: (err) => {
      // console.error('Error loading property:', err);
      this.error = true;
      this.loading = false;
    }
  });
}

  prepareLightboxImages(): void {
    if (this.propertyImages && this.propertyImages.length > 0) {
      this.lightboxImages = this.propertyImages.map((img: IPropertyImage) => ({
        src: img.imagePath, // Using image_path from IPropertyImage
        caption: this.property?.name || '',
        thumb: img.imagePath
      }));
    }
  }

  // initMap(): void {
  //   if (this.property?.location?.latitude && this.property?.location?.longitude) {
  //     this.mapOptions = {
  //       layers: [
  //         tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
  //           attribution: '© OpenStreetMap contributors'
  //         })
  //       ],
  //       zoom: 15,
  //       center: latLng(this.property?.location?.latitude, this.property?.location?.longitude)
  //     };

  //     this.mapMarkers = [
  //       marker([this.property?.location?.latitude, this.property?.location?.longitude], {
  //         icon: icon({
  //           iconSize: [25, 41],
  //           iconAnchor: [13, 41],
  //           iconUrl: 'assets/marker-icon.png',
  //           shadowUrl: 'assets/marker-shadow.png'
  //         }),
  //         title: this.property.name
  //       })
  //     ];
  //   }
  // }
  getMap(): void {
    if (this.property?.location?.latitude && this.property?.location?.longitude) {
      // Clear any existing map
      const existingMap = document.getElementById('map');
      if (existingMap) {
        existingMap.innerHTML = '';
      }
  
      this.mapOptions = {
        layers: [
          tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
            attribution: '© OpenStreetMap contributors'
          })
        ],
        zoom: 15,
        center: latLng(this.property.location.latitude, this.property.location.longitude)
      };
  
      this.mapMarkers = [
        marker([this.property.location.latitude, this.property.location.longitude], {
          icon: icon({
            iconSize: [25, 41],
            iconAnchor: [13, 41],
            iconUrl: 'assets/marker-icon.png',
            shadowUrl: 'assets/marker-shadow.png'
          }),
          title: this.property.name
        })
      ];
    }
  }
  openLightbox(index: number): void {
    this.lightbox.open(this.lightboxImages, index, {
      wrapAround: true,
      showImageNumberLabel: true,
      disableScrolling: true
    });
  }

  get nightsCount(): number {
    if (!this.checkInDate || !this.checkOutDate) return 0;
    const diff = new Date(this.checkOutDate).getTime() - new Date(this.checkInDate).getTime();
    return Math.ceil(diff / (1000 * 60 * 60 * 24));
  }

  toggleFavorite(): void {
    // Implement favorite toggle logic
  }

  checkAvailability(): void {
    // Implement availability check logic
  }
}