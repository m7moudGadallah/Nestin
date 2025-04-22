import { Component } from '@angular/core';
import { Heart, LucideAngularModule } from 'lucide-angular';

@Component({
  selector: 'app-favorites-page',
  imports: [LucideAngularModule],
  templateUrl: './favorites-page.component.html',
  styleUrl: './favorites-page.component.scss',
})
export class FavoritesPageComponent {
  dummyArray = new Array(8);
  icons = {
    heart: Heart,
  };
}
