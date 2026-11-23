import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-tour-booking',
  imports: [FormsModule],
  templateUrl: './tour-booking.html',
  styleUrl: './tour-booking.css',
})
export class TourBooking {
  Tour_Price:number = 5000;
  noOfpersons:number = 1;
  Total:number = 5000;

  calculateTotal(){
    this.Total = this.noOfpersons * this.Tour_Price;
  }

  bookingStatus:string = "Available";
  buttonText:string = "Book Now";

  isBooked:boolean = false;

  bookNow(){
    this.bookingStatus = "Booking Confirmed Successfully";
    this.buttonText = "Booked";
    this.isBooked = true;
  }
}
