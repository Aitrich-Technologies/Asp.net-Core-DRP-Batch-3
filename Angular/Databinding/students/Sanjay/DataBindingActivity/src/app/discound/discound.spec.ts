import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Discound } from './discound';

describe('Discound', () => {
  let component: Discound;
  let fixture: ComponentFixture<Discound>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Discound],
    }).compileComponents();

    fixture = TestBed.createComponent(Discound);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
