import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-tour-bookings',
  imports: [FormsModule],
  templateUrl: './tour-bookings.html',
  styleUrl: './tour-bookings.css',
})
export class TourBookings {
  tourName = 'Kerala Adventure Tour';
  destination = 'Munnar';
  price = 5000;

  customerName = '';
  persons = 1;

  isBooked = false;
  message = '';

  get totalAmount(): number {
    return this.price * this.persons;
  }

  bookNow() {

    if (this.customerName.trim() === '' || this.persons < 1) {
      this.message = 'Please enter valid booking details.';
      return;
    }

    this.isBooked = true;

    this.message = `Booking Confirmed Successfully! Thank you ${this.customerName}.`;

  }
}
