import { Component, OnInit } from '@angular/core';
import { StudentDetailsComponent } from '../student-details-component/student-details-component';

@Component({
  selector: 'app-student-component',
  imports: [],
  templateUrl: './student-component.html',
  styleUrl: './student-component.css',
})
export class StudentComponent implements OnInit {
  studentName:string = "Arun";
  isPassed = true;
  
  ngOnInit() {
    this.studentName;
  }
}
