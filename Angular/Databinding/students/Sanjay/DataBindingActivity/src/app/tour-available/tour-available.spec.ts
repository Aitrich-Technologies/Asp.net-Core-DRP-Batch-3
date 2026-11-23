import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TourAvailable } from './tour-available';

describe('TourAvailable', () => {
  let component: TourAvailable;
  let fixture: ComponentFixture<TourAvailable>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TourAvailable],
    }).compileComponents();

    fixture = TestBed.createComponent(TourAvailable);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
