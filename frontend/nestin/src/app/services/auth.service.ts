import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  constructor() {}

  public isAuthenticated(): boolean {
    let authToken = localStorage.getItem('accessToken');
    return Boolean(authToken);
  }
}
