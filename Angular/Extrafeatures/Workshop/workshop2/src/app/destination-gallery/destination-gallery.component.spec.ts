import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DestinationGalleryComponent } from './destination-gallery.component';

describe('DestinationGalleryComponent', () => {
  let component: DestinationGalleryComponent;
  let fixture: ComponentFixture<DestinationGalleryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [DestinationGalleryComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DestinationGalleryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
