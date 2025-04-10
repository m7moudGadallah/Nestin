import { Component } from '@angular/core';
import { RouterModule, RouterOutlet } from '@angular/router';
import { IProperty } from '../Models/iproperty';
import { PropertyInfoComponent } from '../Component/property-info/property-info.component';
import { HomeComponent } from '../Component/home/home.component';
import { NgLeafletUniversalModule } from 'ng-leaflet-universal';
import { HttpClient, HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,PropertyInfoComponent,HomeComponent,NgLeafletUniversalModule,HttpClientModule,RouterModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent {
  title = 'nestin';
//   selectedProperty: IProperty = {
//     name: 'Modern Beachside Villa',
//     description: 'Stunning beachfront villa with breathtaking views and all modern amenities.',
//     price_per_night: 350,
//     location: 'Malibu, California',
//     latitude: 34.0259,
//     longitude: -118.7798,
//     max_guests: 6,
//     num_beds: 3,
//     num_bedrooms: 2,
//     num_bathrooms: 2,
//     safety_info: 'Smoke alarm, carbon monoxide detector, first aid kit available.',
//     house_rules: 'No smoking, no pets, no parties.',
//     cancellation_policy: 'Free cancellation within 48 hours.',
//     type: 'Villa'
// }

}