import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  imports: [],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home {
  title:string = "ExampleComponet";
  count:number = 0;
  
  IncreaseCount(){
    this.count++;
  }
  ResetCount(){
    this.count = 0;
  }
}
