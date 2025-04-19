import { TestBed } from '@angular/core/testing';

import { BookingHistoyService } from './booking-histoy.service';

describe('BookingHistoyService', () => {
  let service: BookingHistoyService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(BookingHistoyService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
