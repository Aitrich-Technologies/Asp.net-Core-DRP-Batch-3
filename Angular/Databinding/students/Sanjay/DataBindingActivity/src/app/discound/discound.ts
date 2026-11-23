import { Component } from '@angular/core';

@Component({
  selector: 'app-discound',
  imports: [],
  templateUrl: './discound.html',
  styleUrl: './discound.css',
})
export class Discound {
  Original_Tour_Price: number = 20000;
  Discound:number = 10;

  final:number = this.Original_Tour_Price * this.Discound / 100;
}
