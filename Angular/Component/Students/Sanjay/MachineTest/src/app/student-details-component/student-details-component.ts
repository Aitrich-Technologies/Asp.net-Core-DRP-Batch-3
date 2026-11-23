import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-student-details-component',
  imports: [],
  templateUrl: './student-details-component.html',
  styleUrl: './student-details-component.css',
})
export class StudentDetailsComponent implements OnChanges {
    @Input() age:number = 0 ;

  ngOnChanges(changes: SimpleChanges) {
      console.log(changes['age']);

  }
}
