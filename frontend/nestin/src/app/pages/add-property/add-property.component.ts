import { ChangeDetectorRef, Component, OnInit } from '@angular/core';

import { AbstractControl, FormArray, FormBuilder, FormGroup, ReactiveFormsModule, ValidationErrors, Validators } from '@angular/forms';

import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { catchError, finalize, map, Observable, of, retry, tap } from 'rxjs';
import { IPropertyAmenity } from '../../models/domain/iproperty-amenity';
import { IPropertyType } from '../../models/domain/iproperty-type';
import { IPropertyInfo } from '../../models/domain/iproperty-info';
import { AddPropertyService } from '../../services/add-property.service';
import { PropertyService } from '../../services/property.service';



@Component({
  selector: 'app-add-property',
  imports: [CommonModule,RouterModule,ReactiveFormsModule],
  templateUrl: './add-property.component.html',
  styleUrl: './add-property.component.css'
})
export class AddPropertyComponent  implements OnInit{

  propertyForm: FormGroup;
  amenities: IPropertyAmenity[] = [];
  propertyTypes: IPropertyType[] = [];
  isLoading = false;
 

  constructor(
    private fb: FormBuilder,
    private cd: ChangeDetectorRef,
    private propertyService: PropertyService,
    private addPropertyService: AddPropertyService,
  ) {
    this.propertyForm = this.fb.group({
      title: ['', Validators.required],
      description: ['', [Validators.required, Validators.minLength(50)]],
      safetyInfo: ['', Validators.required],
      houseRules: ['', Validators.required],
      cancellationPolicy: ['', Validators.required],
      maxGuestCount: [, [Validators.required, Validators.min(1)]],
      pricePerNight: [, [Validators.required, Validators.min(0)]],
      latitude: [, Validators.required],
      longitude: [, Validators.required],
      propertyType: ['', Validators.required],
      amenities: this.fb.array([]),
      
      
      location: this.fb.group({
        country: ['', Validators.required],
        city: ['', Validators.required],
        state: [''],
        postalCode: [''],
        address: ['', Validators.required],
        neighborhood: ['']
      }),
      
      
      spaceSummaries: this.fb.array([]),
      
      
      spaceItemSummaries: this.fb.array([]),
      
      availability: this.fb.group({
        startDate: ['', Validators.required],
        endDate: ['', Validators.required]
      })
    })
  }

  ngOnInit(): void {
    this.loadAmenities();
    this.loadPropertyTypes();
  }


  // loadAmenities(): void {
  //   this.propertyService.getAllAmenities()
  //     .subscribe({
  //       next: (amenities) => {
  //         this.amenities = amenities;
  //         console.log('Processed amenities:', amenities);
  //       },
  //       error: (err) => console.error('Error loading amenities:', err)
  //     });
  // }
  

  loadPropertyTypes(): void {
    this.propertyService.getPropertyTypes()
      .pipe(
        map((response: unknown) => (response as { items: IPropertyType[] }).items)
      )
      .subscribe((types) => {
        this.propertyTypes = types;
        console.log('Processed Types:', types);
      });
  }

  onAmenityChange(event: any, amenity: IPropertyAmenity): void {
    const amenitiesArray = this.propertyForm.get('amenities') as FormArray;
    
    if (event.target.checked) {
      amenitiesArray.push(this.fb.control(amenity));
    } else {
      const index = amenitiesArray.controls.findIndex(x => x.value.id === amenity?.id);
      amenitiesArray.removeAt(index);
    }
  }


  get spaceSummariesArray(): FormArray {
    return this.propertyForm.get('spaceSummaries') as FormArray;
  }

  
  get spaceItemSummariesArray(): FormArray {
    return this.propertyForm.get('spaceItemSummaries') as FormArray;
  }

  addSpaceSummary(): void {
    const spaceSummaries = this.propertyForm.get('spaceSummaries') as FormArray;
    spaceSummaries.push(this.fb.group({
      name: ['', Validators.required],
      count: [1, [Validators.required, Validators.min(1)]],
      icon: ['']
    }));
  }

  removeSpaceSummary(index: number): void {
    const spaceSummaries = this.propertyForm.get('spaceSummaries') as FormArray;
    spaceSummaries.removeAt(index);
  }

  addSpaceItemSummary(): void {
    const spaceItemSummaries = this.propertyForm.get('spaceItemSummaries') as FormArray;
    spaceItemSummaries.push(this.fb.group({
      name: ['', Validators.required],
      count: [1, [Validators.required, Validators.min(1)]],
      icon: ['']
    }));
  }

  removeSpaceItemSummary(index: number): void {
    const spaceItemSummaries = this.propertyForm.get('spaceItemSummaries') as FormArray;
    spaceItemSummaries.removeAt(index);
  }



  onSubmit(): void {
    if (this.propertyForm.invalid) {
      this.propertyForm.markAllAsTouched();
      return;
    }

    this.isLoading = true;
    
    const formValue = this.propertyForm.value;
    const propertyData: Partial<IPropertyInfo> = {
      ...formValue,
      averageRating: 0,
      reviewCount: 0,
    
    };



    //after finish api
    this.addPropertyService.createProperty(propertyData, this.selectedFiles).subscribe({
      next: (property) => {
     
        this.isLoading = false;
      },
      error: (error) => {
        
        this.isLoading = false;
      }
    });
  }

  //======================================upload pictures section======================================== 

  selectedFiles: File[] = [];
  previewUrls: string[] = [];
  maxPhotos = 5; 
  isUploading = false;
  uploadProgress: number[] = []; 



  onFileSelected(event: any): void {
    const files: FileList = event.target.files;
    
    
    if (this.selectedFiles.length + files.length > this.maxPhotos) {
      alert(`You can upload a maximum of ${this.maxPhotos} photos`);
      return;
    }

 
    for (let i = 0; i < files.length; i++) {
      const file = files[i];
      
      
      if (!file.type.match(/image\/*/)) {
        alert('Only image files are allowed');
        continue;
      }

     
      if (file.size > 5 * 1024 * 1024) {
        alert(`File ${file.name} is too large (max 5MB)`);
        continue;
      }

      this.selectedFiles.push(file);
      this.readAndPreview(file);
    }
  }

  private readAndPreview(file: File): void {
    
    const objectUrl = URL.createObjectURL(file);
    this.previewUrls.push(objectUrl);
    
   
    const reader = new FileReader();
    reader.onload = (e: any) => {
     
      const index = this.previewUrls.indexOf(objectUrl);
      if (index !== -1) {
        this.previewUrls[index] = e.target.result;
      }
    };
    reader.readAsDataURL(file);
  }

  removeImage(index: number): void {
    const url = this.previewUrls[index];
    if (url && typeof url === 'string' && url.startsWith('blob:')) {
      URL.revokeObjectURL(url);
    }
    this.previewUrls.splice(index, 1);
    this.selectedFiles.splice(index, 1);
  }

  setPrimaryImage(index: number): void {
    
    const [selectedImage] = this.previewUrls.splice(index, 1);
    const [selectedFile] = this.selectedFiles.splice(index, 1);
    
    this.previewUrls.unshift(selectedImage);
    this.selectedFiles.unshift(selectedFile);
  }

// =================================== availability ================================

today = new Date(); 

dateRangeValidator(control: AbstractControl): ValidationErrors | null {
  const startDate = control.get('startDate')?.value;
  const endDate = control.get('endDate')?.value;
  
  if (startDate && endDate) {
    const start = new Date(startDate);
    const end = new Date(endDate);
    const today = new Date();
    today.setHours(0, 0, 0, 0); // Compare dates only, ignore time
    
    
    if (start < today) {
      return { pastDate: true };
    }
    
   
    if (end < start) {
      return { dateRange: true };
    }
  }
  return null;
}

get availability() {
  return this.propertyForm.get('availability');
}



// ========================================load amenities with category and pagination====================================
currentPage = 1;
totalPages = 1;
pageSize = 10;
loading = false;

// Initial load
loadAmenities(): void {
  this.loading = true;
  this.propertyService.getAmenitiesPaginated(this.currentPage, this.pageSize)
    .subscribe({
      next: (response) => {
        this.amenities = response.items;
        this.totalPages = Math.ceil(response.metaData.total / this.pageSize);
        this.loading = false;
      },
      error: (err) => {
        console.error('Error loading amenities:', err);
        this.loading = false;
      }
    });
}

// Pagination controls
goToPage(page: number): void {
  if (page < 1 || page > this.totalPages || page === this.currentPage) return;
  
  this.currentPage = page;
  this.loadAmenities();
}

// Generate page numbers for pagination controls
getPageNumbers(): number[] {
  const pages = [];
  const maxVisiblePages = 5; // Adjust as needed
  
  let start = Math.max(1, this.currentPage - Math.floor(maxVisiblePages/2));
  let end = Math.min(this.totalPages, start + maxVisiblePages - 1);
  
  // Adjust if we're at the end
  if (end - start + 1 < maxVisiblePages) {
    start = Math.max(1, end - maxVisiblePages + 1);
  }
  
  for (let i = start; i <= end; i++) {
    pages.push(i);
  }
  
  return pages;
}
}