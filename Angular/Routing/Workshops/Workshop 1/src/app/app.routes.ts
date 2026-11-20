import { Routes } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { ToursComponent } from './tours/tours.component';
import { TourDetailsComponent } from './tour-details/tour-details.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';

import { tourGuard } from './guards/tour.guard';

export const routes: Routes = [
  {
    path: '',
    component: HomeComponent,
  },

  {
    path: 'tours',
    component: ToursComponent,
  },

  {
    path: 'tour-details/:id',
    component: TourDetailsComponent,
    canActivate: [tourGuard],
  },

  {
    path: '**',
    component: PageNotFoundComponent,
  },
];
