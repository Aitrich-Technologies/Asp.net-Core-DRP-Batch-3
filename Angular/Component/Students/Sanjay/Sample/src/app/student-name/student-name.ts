import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-student-name',
  imports: [],
  templateUrl: './student-name.html',
  styleUrl: './student-name.css',
})
export class StudentName implements OnInit{
  Title:string = '';

  ngOnInit(){
    this.Title = "Arun"
  }
}
