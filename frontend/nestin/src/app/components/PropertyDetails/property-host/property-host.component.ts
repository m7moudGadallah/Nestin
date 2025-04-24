import { Component, Input, OnInit } from '@angular/core';
import { IPropertyInfo } from '../../../models/domain/iproperty-info';
import { CommonModule } from '@angular/common';
import {
  BadgeCheck,
  CalendarDays,
  CheckCircle2,
  LucideAArrowDown,
  LucideAngularModule,
  Mail,
  Star,
} from 'lucide-angular';
import { ActivatedRoute } from '@angular/router';
import { PropertyService } from '../../../services/property.service';

@Component({
  selector: 'app-property-host',
  imports: [CommonModule, LucideAngularModule],
  templateUrl: './property-host.component.html',
  styleUrl: './property-host.component.css',
})
export class PropertyHostComponent implements OnInit {
  // private apiUrl = 'http://localhost:3001';

  @Input() property!: IPropertyInfo;

  constructor(private propertyService: PropertyService) {}

  // propertyId: string = '';
  // constructor(private route: ActivatedRoute) { }
  //  private apiUrl = `https://localhost:7026/api/v1/Properties`;
  //  ngOnInit(): void {
  //   this.propertyId = this.route.snapshot.paramMap.get('id') || '';
  //   console.log('Property ID:', this.propertyId);
  // }

  icons = {
    calendar: CalendarDays,
    star: Star,
    check: CheckCircle2,
    verified: BadgeCheck,
    mail: Mail,
  };

  // get hostingYears(): number {
  //   if (!this.property.owner?.joinedAt) return 0;
  //   const joinedDate = new Date(this.property.owner.joinedAt);
  //   console.log(joinedDate);
  //   return new Date().getFullYear() - joinedDate.getFullYear();
  // }

  ngOnInit() {
    this.propertyService
      .getPropertyById(this.property?.id)
      .subscribe(property => {
        // Patch missing owner details if needed
        property.body.owner = {
          ...property.body.owner,
          firstName: property.body.owner.firstName || 'Host',
          photo: {
            id: 'default',
            photoUrl:
              property.body.owner.photo?.photoUrl || 'favicon.ico',
          },
          email: '',
          lastName: property.body.owner.lastName,
          phoneNumber: '',
          bio: '',
          birthDate: '',
          userId: property.body.owner.userId,
        };

        this.property = property.body;
      });
  }

  get hostName(): string {
    return `${this.property.owner?.firstName || ''} ${this.property.owner?.lastName || ''}`.trim();
  }

  // get joinDate(): string {
  //   if (!this.property.owner?.joinedAt) return '';
  //   return new Date(this.property.owner.joinedAt).toLocaleDateString();
  // }

  get isSuperhost(): boolean {
    return (
      this.property.reviewCount >= 10 && this.property.averageRating >= 4.3
    );
  }

  get responseRate(): number {
    // You might want to calculate this based on actual data
    return 95; // Default value or implement actual calculation
  }
}
