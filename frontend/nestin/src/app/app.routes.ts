import { Routes } from '@angular/router';
import { HomePageComponent } from './pages/home-page/home-page.component';
import { BlankLayoutComponent } from './layouts/blank-layout/blank-layout.component';
import { MainLayoutComponent } from './layouts/main-layout/main-layout.component';

export const routes: Routes = [
  {
    path: '',
    component: MainLayoutComponent,
    children: [
      { path: '', redirectTo: 'home', pathMatch: 'full' },
      { path: 'home', component: HomePageComponent },
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
