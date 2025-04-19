import { Component, OnInit, ElementRef, HostListener, ViewChild  } from '@angular/core';
import { firstValueFrom, forkJoin } from 'rxjs';
import { LucideAngularModule, FileIcon, Globe } from 'lucide-angular';
import { LocationsService } from '../../services/allLocations/locations.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { Property } from '../../models/listings/propertyApi';
import { Country } from '../../models/locationSearch/countries';
import { Location as AppLocation } from '../../models/locationSearch/locations';
import { Region } from '../../models/locationSearch/regions';
import {ApiResponse} from '../../models/ApiResponse';
import { AvailabilityService } from '../../services/availableDates/availability.service';
import { GuestsService } from '../../services/guests/guests.service';

@Component({
  selector: 'app-header',
  imports: [LucideAngularModule, CommonModule, FormsModule],
  templateUrl: './header.component.html',
  styleUrl: './header.component.css',
})
export class HeaderComponent  {
//lucide icons
  icons = {
    global: Globe,
  };
  constructor(private locationService:LocationsService,
              private availabilityService : AvailabilityService,
              private guestService: GuestsService
             ) {}
  properties: any[] = [];
  allProperties: any[] = [];
  //to apply search on locations------------------------------------------------------------------
  searchQuery = '';
  suggestions: any[] = [];
  //dates variables -------------------------------------------------
  checkInDate : string ='';
  checkOutDate : string = '';
  //guests variables------------------------------------
  adults = 1;
  children = 0;
  infants =0;
  pets=0;
 
  onSearchClick() {
    //filteration based on locations ------------------------------------------------
    if (!this.searchQuery.trim()) {
      this.suggestions = [];
      return;
    }
    console.log("Searching for:", this.searchQuery); //for testing

  this.locationService.searchAll(this.searchQuery).subscribe((response:any[]) => {
    const [locations, countries, regions] = response;
    console.log("Suggestions:", locations, countries, regions); //for testing fetching data
    const safeLocations = Array.isArray(locations.items) ? locations.items : [];
    const safeCountries = Array.isArray(countries.items) ? countries.items : [];
    const safeRegions = Array.isArray(regions.items) ? regions.items : [];

    this.suggestions = [
      ...safeLocations.map((item: any) => ({ ...item, type: 'location' })),
      ...safeCountries.map((item: any) => ({ ...item, type: 'country' })),
      ...safeRegions.map((item: any) => ({ ...item, type: 'region' }))
    ];
    console.log("Suggestions:", this.suggestions); //for test
 
  
  });
  let filtered = [...this.allProperties]; //a copy from allProperties variable

  //filteration of guests
  this.filterByGuests

  //filteration of available dates
  this.filterByDate
  

}
  onSuggestionSelect(suggestion: { id: number; name: string; type: 'location' | 'country' | 'region' }): void {
    this.searchQuery = suggestion.name;
    this.suggestions = [];

    let locationId: number | undefined;
    let countryId: number | undefined;
    let regionId: number | undefined;

    if (suggestion?.type === 'location') locationId = suggestion.id;
    else if (suggestion?.type === 'country') countryId = suggestion.id;
    else if (suggestion?.type === 'region') regionId = suggestion.id;

    this.locationService.searchPropertiesByLocation(locationId, countryId, regionId).subscribe(data => {
      this.properties = Array.isArray(data) ? data : [];
    });
  }

  //guest filteration function
  filterByGuests(): void {
    const totalGuests = this.adults + this.children;
    if (!totalGuests || this.allProperties.length === 0) return;
  
    this.properties = this.allProperties.filter(p => p.maxGuests >= totalGuests);
  }

  //dates filteration function
  filterByDate(): void {
    if (!this.checkInDate || !this.checkOutDate || this.allProperties.length === 0) return;
  
    const requests = this.allProperties.map(p =>
      firstValueFrom(this.availabilityService.getAvailableProperties(p.id, this.checkInDate, this.checkOutDate))
        .then((res: any) => ({ property: p, isAvailable: (res ?? []).length > 0 }))
        .catch(() => ({ property: p, isAvailable: false }))
    );
  
    Promise.all(requests).then(results => {
      const available = results.filter((r: { isAvailable: any; }) => r.isAvailable).map((r: { property: any; }) => r.property);
      this.properties = available;
    }).catch(err => {
      console.error("Error fetching availability:", err);
    });
  }
  
  //end of search  ---------------------------------------------------------------------
  //guest menu --------------------------------------------------------------------------------
  isGuestMenuOpen = false;
 

  get guestText(): string {
    const total = this.adults + this.children + this.infants+ this.pets;
    return total > 0 ? `${total} guest${total > 1 ? 's' : ''}` : 'Add guests';
  }
  toggleGuestMenu(event: MouseEvent): void {
    event.stopPropagation();
    this.isGuestMenuOpen = !this.isGuestMenuOpen;
    console.log("Toggle clicked. isGuestMenuOpen:", this.isGuestMenuOpen);
  }

  applyGuestSelection(): void {
    this.isGuestMenuOpen = false;
  }
  //to close the menu when click outside it
  @HostListener('document:click')
  closeGuestMenu(): void {
    this.isGuestMenuOpen = false;
  }
  //end of guest menu ---------------------------------------------------------------------------------
  

  
  
  
 
 
}

