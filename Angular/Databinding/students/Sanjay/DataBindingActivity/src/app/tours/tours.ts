import { Component } from '@angular/core';

@Component({
  selector: 'app-tours',
  imports: [],
  templateUrl: './tours.html',
  styleUrl: './tours.css',
})
export class Tours {
  Destiantion:string = "Paris";
  Country:string = "France";
  Tour_Agency:string = "Aitrich Agency";
  Price:string = "25,000";

  bgColor:string = "lightblue";
  changeBackground(){
    this.bgColor = "orange"
  }

  
}
