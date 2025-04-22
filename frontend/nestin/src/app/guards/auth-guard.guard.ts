import { CanActivateFn } from '@angular/router';
import { Router } from '@angular/router';
import { inject } from '@angular/core';

export const authGuardGuard: CanActivateFn = (route, state) => {
  const router = inject(Router); // Inject Router

  const token = localStorage.getItem('authToken');

  if (token) {
    return true; // Allow the route to activate
  } else {
    return router.parseUrl('/login'); // Redirect to login if not authenticated
  }
};
