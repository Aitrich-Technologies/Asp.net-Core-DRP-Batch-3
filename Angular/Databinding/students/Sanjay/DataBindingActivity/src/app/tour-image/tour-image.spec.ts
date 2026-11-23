import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TourImage } from './tour-image';

describe('TourImage', () => {
  let component: TourImage;
  let fixture: ComponentFixture<TourImage>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TourImage],
    }).compileComponents();

    fixture = TestBed.createComponent(TourImage);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
