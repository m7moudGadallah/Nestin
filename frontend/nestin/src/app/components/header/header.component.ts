import { Component, OnInit } from '@angular/core';
//import { bootstrapApplication } from '@angular/platform-browser';
import { LucideAngularModule, FileIcon, Globe } from 'lucide-angular';
import { LocationsService } from '../../services/countries/locations.service';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-header',
  imports: [LucideAngularModule, CommonModule, FormsModule],
  templateUrl: './header.component.html',
  styleUrl: './header.component.css',
})
export class HeaderComponent implements OnInit {
  //readonly FileIcon = FileIcon; //lucide icons
  icons = {
    global: Globe,
  };
  countries: any[] = [];
  filteredCountries: any[] = [];
  searchTerm: string = '';
  showCountries: boolean = false;

  constructor(private countryService: LocationsService) {}
  ngOnInit(): void {
    this.countryService.getAllCountries().subscribe(data => {
      this.countries = data;
      this.filteredCountries = data;
    });
  }
  toggleCountriesMenu(): void {
    this.showCountries = !this.showCountries;
    if (this.showCountries) {
      this.filteredCountries = [...this.countries]; // لما تفتح، يظهر كل الدول
    }
  }
  // filterCountries(){
  //   if (this.searchTerm){
  //     this.filteredCountries = this.countries.filter(country =>
  //       country.name.toLowerCase().includes(this.searchTerm.toLowerCase())
  //     );
  //   } else{
  //     this.filteredCountries = this.countries;
  //   }
  // }
  filterCountries() {
    const term = this.searchTerm.toLowerCase();
    this.filteredCountries = this.countries.filter(country =>
      country.name.toLowerCase().includes(term)
    );
  }
  selectCountry(countryName: string): void {
    console.log('Selected country:', countryName);
    this.showCountries = false;
    this.searchTerm = countryName;
  }
}
// bootstrapApplication(HeaderComponent);
