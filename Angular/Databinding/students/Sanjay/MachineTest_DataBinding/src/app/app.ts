import { Component, signal } from '@angular/core';
import { CustomerDetails } from './customer-details/customer-details';
import { TourBooking } from './tour-booking/tour-booking';

@Component({
  selector: 'app-root',
  imports: [CustomerDetails,TourBooking],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('MachineTest_DataBinding');
}
