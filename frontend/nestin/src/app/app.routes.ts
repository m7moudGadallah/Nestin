import { Routes } from '@angular/router';
import { HomePageComponent } from './pages/home-page/home-page.component';
import { PropertyInfoComponent } from './pages/property-info-page/property-info.component';
import { BlankLayoutComponent } from './layouts/blank-layout/blank-layout.component';
import { MainLayoutComponent } from './layouts/main-layout/main-layout.component';
import { authGuard } from './guards/auth.guard';
import { BookingHistoryComponent } from './pages/booking-history-page/booking-history.component';

export const routes: Routes = [
  {
    path: '',
    component: MainLayoutComponent,
    children: [
      { path: '', redirectTo: 'home', pathMatch: 'full' },
      { path: 'home', component: HomePageComponent },
      { path: 'property/:id', component: PropertyInfoComponent },
      {path:'bookingHistory',component:BookingHistoryComponent},
    ],
  },
  {
    path: '',
    canActivate: [authGuard],
    component: MainLayoutComponent,
    children: [
      { path: '', redirectTo: 'home', pathMatch: 'full' },
      { path: 'home', component: HomePageComponent },
      {
        path: 'favorites',
        loadComponent: () =>
          import('./pages/favorites-page/favorites-page.component').then(
            m => m.FavoritesPageComponent
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
