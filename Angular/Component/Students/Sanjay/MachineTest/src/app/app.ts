import { Component, signal } from '@angular/core';
import { StudentComponent } from './student-component/student-component';
import { StudentDetailsComponent } from './student-details-component/student-details-component';

@Component({
  selector: 'app-root',
  imports: [StudentComponent,StudentDetailsComponent],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('MachineTest');
  
}
