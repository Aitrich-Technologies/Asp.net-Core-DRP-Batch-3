import { TestBed } from '@angular/core/testing';
import { CanActivateFn } from '@angular/router';

import { tourGuard } from './tour.guard';

describe('tourGuard', () => {
  const executeGuard: CanActivateFn = (...guardParameters) => 
      TestBed.runInInjectionContext(() => tourGuard(...guardParameters));

  beforeEach(() => {
    TestBed.configureTestingModule({});
  });

  it('should be created', () => {
    expect(executeGuard).toBeTruthy();
  });
});
