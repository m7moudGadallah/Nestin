import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { AbstractControl, FormArray, FormBuilder, FormGroup, ReactiveFormsModule, ValidationErrors, Validators } from '@angular/forms';


import { CommonModule } from '@angular/common';
import { Router, RouterModule } from '@angular/router';

import { catchError, finalize, map, Observable, of, retry, tap } from 'rxjs';
import { AddPropertyService } from '../../services/add-property.service';
import { IPropertyAmenity } from '../../models/domain/iproperty-amenity';
import { IPropertyType } from '../../models/domain/iproperty-type';
import { IPropertyInfo } from '../../models/domain/iproperty-info';
import { PropertyService } from '../../services/property-service.service';
import { ILocation } from '../../models/domain/ilocation';
import { ToastService } from '../../services/toast.service';




@Component({
  selector: 'app-add-property',
  imports: [CommonModule,RouterModule,ReactiveFormsModule],
  templateUrl: './add-property.component.html',
  styleUrl: './add-property.component.css'
})
export class AddPropertyComponent  implements OnInit{

  propertyForm: FormGroup;
  propertyTypes: IPropertyType[] = [];
  locations: ILocation[] = [];
  isLoading = false;
  loadError: string | null = null;
  errorMessage: string | null = null;

  constructor(
    private fb: FormBuilder,
    private propertyService: PropertyService,
    private addPropertyService: AddPropertyService,
    private router: Router,
    private toastr: ToastService
  ) {
    this.propertyForm = this.fb.group({
      title: ['', [
        Validators.required,
        Validators.minLength(5),
        Validators.maxLength(100),
        Validators.pattern(/^[\p{L}\p{N}\s.,!?'&-]{5,100}$/u) 
      ]],
      description: ['', [
        Validators.required,
        Validators.minLength(10),
        Validators.maxLength(1000),
        Validators.pattern(/^[\p{L}\p{N}\s.,!?'&()\-:;\n\r]{10,1000}$/u)
      ]],
      propertyTypeId: ['', Validators.required],
      locationId: ['', Validators.required],
      pricePerNight: ['', [Validators.required, Validators.min(0.01)]],
      latitude: ['', [Validators.required, Validators.min(-90), Validators.max(90)]],
      longitude: ['', [Validators.required, Validators.min(-180), Validators.max(180)]],
      safetyInfo: ['', [
        Validators.required,
        Validators.minLength(10),
        Validators.maxLength(500),
        Validators.pattern(/^[\p{L}\p{N}\s.,!?'()"-]{10,500}$/u) // 'u' flag for Unicode
      ]],
      houseRules: ['', [
        Validators.required,
        Validators.minLength(10),
        Validators.maxLength(500),
        Validators.pattern(/^[\p{L}\p{N}\s.,!?'()"-]{10,500}$/u)
      ]],
      cancellationPolicy: ['', [
        Validators.required,
        Validators.minLength(10),
        Validators.maxLength(500),
        Validators.pattern(/^[\p{L}\p{N}\s.,!?'()"-]{10,500}$/u)
      ]]
    });
  }

  ngOnInit(): void {
    this.loadFormData();
  }

  loadFormData(): void {
    this.isLoading = true;
    this.loadError = null;

    
    this.propertyService.getPropertyTypes().pipe(
      map(response => response.items)
    )
    .subscribe({
      next: (types: IPropertyType[]) => {
        this.propertyTypes = types;
        this.checkLoadingComplete();
        console.log('Property Types:', this.propertyTypes);
      },
      error: (err) => {
        this.handleLoadError('Failed to load property types');
      }
    });
    

   
    this.propertyService.getAllLocations().pipe(
      map(response => {
       
        if (!Array.isArray(response)) {
          return Object.values(response);
        }
        return response;
      })
    ).subscribe({
      next: (locations) => {
        this.locations = locations as ILocation[];
        console.log('Locations:', this.locations);
        this.checkLoadingComplete();
      },
      error: (err) => {
        this.handleLoadError('Failed to load locations');
      }
    });
  }

  private checkLoadingComplete(): void {
    if (this.propertyTypes.length > 0 && this.locations.length > 0) {
      this.isLoading = false;
    }
  }

  private handleLoadError(message: string): void {
    this.loadError = message;
    this.isLoading = false;
    
  }

  onSubmit(): void {
    if (this.propertyForm.valid) {
      this.addPropertyService.addProperty(this.propertyForm.value).subscribe({
        next: (response) => {
          console.log('Property added successfully:', response);
          this.toastr.showSuccess('Property added successfully!', 5000);
          // this.router.navigate(['/properties', response.id]);
        },
        error: (error) => {
          this.errorMessage = this.getErrorMessage(error);
          this.toastr.showError(this.errorMessage, 5000);
        }
      });
    }
  }


  private getErrorMessage(error: any): string {
    if (error.error && error.error.message) {
      return error.error.message; // Backend error message
    } else if (error.status === 0) {
      return 'Cannot connect to server. Please try again later.';
    } else if (error.status === 401) {
      return 'You are not authorized. Please log in to continue.'; // Handling 401 Unauthorized
    } else if (error.status === 403) {
      return 'Access denied. You do not have permission.';
    } else if (error.status === 404) {
      return 'Requested resource not found.';
    } else if (error.status === 500) {
      return 'Server error occurred. Please contact support.';
    } else {
      return 'An unknown error occurred. Please try again.';
    }
  }
  

  onCancel(): void {
    // this.toastr.showSuccess('Property added successfully!', 5000);
    // this.router.navigate(['/properties']);
  }

}