import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-tour-booking',
  imports: [FormsModule],
  templateUrl: './tour-booking.html',
  styleUrl: './tour-booking.css',
})
export class TourBooking {
  tourName: string = "Paris";
  price:number = 10000;
  customerName:string = '';
  status:string = '';

  confirm(){
    this.status =  "Booking Confirmed Successfully";
  }
}
