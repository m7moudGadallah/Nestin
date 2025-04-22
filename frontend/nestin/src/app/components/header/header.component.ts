import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { StickyNavDirective } from '../../directive/sticky-nav.directive';

@Component({
  selector: 'app-header',
  imports: [CommonModule, RouterModule, StickyNavDirective],
  templateUrl: './header.component.html',
  styleUrl: './header.component.scss',
})
export class HeaderComponent {
  isLoggedIn: boolean = false;

  logout() {}
}
