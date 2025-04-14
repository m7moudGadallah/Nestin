import { Component, ElementRef, ViewChild } from '@angular/core';

@Component({
  selector: 'app-footer',
  imports: [],
  templateUrl: './footer.component.html',
  styleUrl: './footer.component.css',
})
export class FooterComponent {
  // @ViewChild('scrollable') scrollable!: ElementRef;
  // showLeft = false;
  // showRight = false;
  // ngAfterViewInit() {
  //   setTimeout(() => this.checkScroll(), 100);
  // }
  // scrollLeft() {
  //   this.scrollable.nativeElement.scrollBy({ left: -200, behavior: 'smooth' });
  // }
  // scrollRight() {
  //   this.scrollable.nativeElement.scrollBy({ left: 200, behavior: 'smooth' });
  // }
  // checkScroll() {
  //   const scrollEl = this.scrollable.nativeElement;
  //   this.showLeft = scrollEl.scrollLeft > 0;
  //   this.showRight =
  //     scrollEl.scrollLeft + scrollEl.clientWidth < scrollEl.scrollWidth;
  // }
}
