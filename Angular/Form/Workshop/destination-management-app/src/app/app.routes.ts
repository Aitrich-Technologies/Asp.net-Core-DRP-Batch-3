import { Routes } from '@angular/router';
import { DestinationListComponent } from './features/destination-list/destination-list.component';
import { DestinationFormComponent } from './features/destination-form/destination-form.component';

export const routes: Routes = [
  { path: '', redirectTo: 'destinations', pathMatch: 'full' },
  { path: 'destinations', component: DestinationListComponent },
  { path: 'destinations/add', component: DestinationFormComponent },
  { path: 'destinations/edit/:id', component: DestinationFormComponent },
  { path: '**', redirectTo: 'destinations' }
];
