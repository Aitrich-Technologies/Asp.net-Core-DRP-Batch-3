import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TourBookings } from './tour-bookings';

describe('TourBookings', () => {
  let component: TourBookings;
  let fixture: ComponentFixture<TourBookings>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TourBookings],
    }).compileComponents();

    fixture = TestBed.createComponent(TourBookings);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
