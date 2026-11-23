import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-tour-available',
  imports: [FormsModule],
  templateUrl: './tour-available.html',
  styleUrl: './tour-available.css',
})
export class TourAvailable {
  isAvailable: boolean = true;

  destination:string = "";
}
