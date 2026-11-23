import { ComponentFixture, TestBed } from '@angular/core/testing';

import { Consultant } from './consultant';

describe('Consultant', () => {
  let component: Consultant;
  let fixture: ComponentFixture<Consultant>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [Consultant],
    }).compileComponents();

    fixture = TestBed.createComponent(Consultant);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
