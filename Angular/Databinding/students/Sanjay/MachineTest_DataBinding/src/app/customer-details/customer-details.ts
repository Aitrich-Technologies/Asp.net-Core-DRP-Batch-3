import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-customer-details',
  imports: [FormsModule],
  templateUrl: './customer-details.html',
  styleUrl: './customer-details.css',
})
export class CustomerDetails {
  customerName: string = '';

  destination:string = '';

  tourPrice:number = 5000;

  noOfPerson:number = 1;

  get total():number{
    return this.tourPrice * this.noOfPerson;
  }
}
