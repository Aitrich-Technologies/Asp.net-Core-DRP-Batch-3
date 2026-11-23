import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-profile',
  imports: [FormsModule],
  templateUrl: './profile.html',
  styleUrl: './profile.css',
})
export class Profile {
  CustomerName:string = "Arun";
  Email:string = "arun@gmail.com";
  Destination:string = "Ernakulam";
  NumberOfPerson:number = 0;
}
