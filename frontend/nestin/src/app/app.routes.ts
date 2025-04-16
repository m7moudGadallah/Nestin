import { Routes } from '@angular/router';
import { MapComponent } from './components/map/map.component';
import { BookingComponent } from './pages/booking/booking/booking.component';
import { HomeComponent } from './pages/home/home.component';

export const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'map', component: MapComponent },
  { path: 'booking', component: BookingComponent },
];
