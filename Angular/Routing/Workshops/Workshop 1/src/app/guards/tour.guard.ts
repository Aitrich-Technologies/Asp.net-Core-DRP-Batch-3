import { CanActivateFn } from '@angular/router';

export const tourGuard: CanActivateFn = (route) => {
  const id = Number(route.paramMap.get('id'));

  return id > 0;
};
