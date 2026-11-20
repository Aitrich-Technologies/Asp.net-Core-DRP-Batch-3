import { Routes } from '@angular/router';
import { BookingListComponent } from './features/booking-list/booking-list.component';
import { BookingDetailsComponent } from './features/booking-details/booking-details.component';
import { PageNotFoundComponent } from './features/page-not-found/page-not-found.component';

export const routes: Routes = [
  { path: '', component: BookingListComponent },
  { path: 'booking-details/:id', component: BookingDetailsComponent },
  { path: '**', component: PageNotFoundComponent }
];
