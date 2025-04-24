import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Heart, LucideAngularModule } from 'lucide-angular';

@Component({
  selector: 'app-favorite-button',
  imports: [LucideAngularModule],
  templateUrl: './favorite-button.component.html',
  styleUrl: './favorite-button.component.css',
})
export class FavoriteButtonComponent {
  @Input() isFavorite: boolean = false;
  @Input() size: number = 24;
  @Input() color: string = '#ffffff';
  @Input() filledColor: string = '#ff385c';
  @Output() toggle = new EventEmitter<boolean>();

  icon = {
    heart: Heart,
  };

  onClick(event: Event) {
    event.stopPropagation();
    this.isFavorite = !this.isFavorite;
    this.toggle.emit(this.isFavorite);
  }
}
