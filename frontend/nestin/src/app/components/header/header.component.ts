import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Router, RouterModule } from '@angular/router';
import { StickyNavDirective } from '../../directive/sticky-nav.directive';
import { AuthService } from '../../services/auth.service';
import { AccountService } from '../../services/account.service';

@Component({
  selector: 'app-header',
  imports: [CommonModule, RouterModule, StickyNavDirective],
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss',
})
export class HeaderComponent {
  constructor(
    private authService: AuthService,
    private accountService: AccountService,
    private router: Router
  ) {}

  get isAuthenticated(): boolean {
    return this.authService.isAuthenticated();
  }

  logout() {
    this.accountService.logout().subscribe({
      next: () => {
        localStorage.removeItem('accessToken');
        localStorage.removeItem('userName');
        localStorage.removeItem('userId');
        // Redirect to home after successful logout
        this.router.navigate(['/home']);
      },
      error: err => {
        console.error('Logout failed:', err);
        // Still redirect to home even if logout API fails
        this.router.navigate(['/home']);
      },
    });
  }
}
