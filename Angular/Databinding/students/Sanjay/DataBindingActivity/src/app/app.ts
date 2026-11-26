import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Tours } from './tours/tours';
import { TourImage } from './tour-image/tour-image';
import { Profile } from './profile/profile';
import { TourBooking } from './tour-booking/tour-booking';
import { TourAvailable } from './tour-available/tour-available';
import { Discound } from './discound/discound';
import { TourBookings } from './tour-bookings/tour-bookings';

@Component({
  selector: 'app-root',
  imports: [Tours,TourImage,Profile,TourBooking,TourAvailable,Discound,TourBookings],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('DataBindingActivity');
}
