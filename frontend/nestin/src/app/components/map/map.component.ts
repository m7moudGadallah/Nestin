import { Component } from '@angular/core';
import { Marker, NgLeafletUniversalModule } from 'ng-leaflet-universal';

@Component({
  selector: 'app-map',
  imports: [NgLeafletUniversalModule],
  templateUrl: './map.component.html',
  styleUrl: './map.component.css',
})
export class MapComponent {
  markers = [
    {
      lat: 30.045, // Latitude
      lng: 31.235, // Longitude
      popupText: 'Hello from Cairo!',
    },
  ];
}
