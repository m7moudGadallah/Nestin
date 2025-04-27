import { Component, EventEmitter, Input, Output, OnInit } from '@angular/core';
import { Heart, LucideAngularModule } from 'lucide-angular';
import { FavoritePropertiesService } from '../../../services/favorite-properties.service';
import { IPropertyInfo } from '../../../models/domain/iproperty-info'; // <-- import IPropertyInfo
import { ToastService } from '../../../services/toast.service'; // <-- import ToastService

@Component({
  selector: 'app-favorite-button',
  standalone: true,
  imports: [LucideAngularModule],
  templateUrl: './favorite-button.component.html',
  styleUrl: './favorite-button.component.scss',
})
export class FavoriteButtonComponent implements OnInit {
  @Input() isFavorite: boolean = false;
  @Input() size: number = 50;
  @Input() color: string = '#ffffff';
  @Input() filledColor: string = '#ff385c';
  @Input() property!: IPropertyInfo; // <== ADD THIS
  @Output() toggle = new EventEmitter<boolean>();

  icon = {
    heart: Heart,
  };

  constructor(
    private favouriteService: FavoritePropertiesService,
    private toastService: ToastService
  ) {}

  ngOnInit(): void {
    console.log('FavoriteButton loaded with property id:', this.property.id);
  }

  onClick(event: Event) {
    event.stopPropagation();

    if (!this.isFavorite) {
      // Add property to favorites
      this.favouriteService.addToFavorites(this.property.id).subscribe({
        next: () => {
          this.isFavorite = true;
          this.toggle.emit(this.isFavorite);
          this.toastService.showSuccess('Property added to favorites.');
          console.log('Property added to favorites.');
        },
        error: error => {
          console.error('Failed to add to favorites:', error);
          this.toastService.showError(
            'Failed to add to favorites. Please try again.'
          );
        },
      });
    } else {
      // Show a message that the property is already in favorites
      this.toastService.showInfo('This property is already in your favorites.');
      console.log('Already favorite.');
    }
  }
}
