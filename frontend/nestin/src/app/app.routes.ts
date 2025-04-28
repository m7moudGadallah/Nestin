import { Routes } from '@angular/router';
import { HomePageComponent } from './pages/home-page/home-page.component';
import { PropertyInfoComponent } from './pages/property-info-page/property-info.component';
import { BlankLayoutComponent } from './layouts/blank-layout/blank-layout.component';
import { MainLayoutComponent } from './layouts/main-layout/main-layout.component';
import { authGuard } from './guards/auth.guard';
import { BookingHistoryComponent } from './pages/booking-history/booking-history.component';
import { BookingPageComponent } from './pages/booking-page/booking-page.component';

export const routes: Routes = [
  {
    path: '',
    component: MainLayoutComponent,
    children: [
      { path: '', redirectTo: 'home', pathMatch: 'full' },
      { path: 'home', component: HomePageComponent },
      { path: 'property/:id', component: PropertyInfoComponent },
    
      
    ],
  },
  {
    path: '',
    component: MainLayoutComponent,
    canActivate: [authGuard], // Applies to all child routes
    children: [
      {
        path: 'favorites',
        loadComponent: () =>
          import('./pages/favorites-page/favorites-page.component').then(
            m => m.FavoritesPageComponent
          ),
      },
      {
        path: 'bookingHistory',
        loadComponent: () =>
          import('./pages/booking-history/booking-history.component').then(
            m => m.BookingHistoryComponent
          ),
      },
      {
        path: 'booking',
        loadComponent: () =>
          import('./pages/booking-page/booking-page.component').then(
            m => m.BookingPageComponent
          ),
      },
    ],
  },
  {
    path: '',
    component: BlankLayoutComponent,
    children: [
      {
        path: 'register',
        loadComponent: () =>
          import('./pages/register-page/register-page.component').then(
            m => m.RegisterPageComponent
          ),
      },
      {
        path: 'login',
        loadComponent: () =>
          import('./pages/login-page/login-page.component').then(
            m => m.LoginPageComponent
          ),
      },
    ],
  },
];
