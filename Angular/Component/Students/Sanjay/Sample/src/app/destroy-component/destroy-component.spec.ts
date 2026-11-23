import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DestroyComponent } from './destroy-component';

describe('DestroyComponent', () => {
  let component: DestroyComponent;
  let fixture: ComponentFixture<DestroyComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DestroyComponent],
    }).compileComponents();

    fixture = TestBed.createComponent(DestroyComponent);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
