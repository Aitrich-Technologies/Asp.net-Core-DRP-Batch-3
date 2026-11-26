import { Component, signal } from '@angular/core';
// import { RouterOutlet } from '@angular/router';
// import { Home } from './home/home';
// import { Example } from './example/example';
// import { StudentName } from './student-name/student-name';
import { Example2 } from './example2/example2';
import { DestroyComponent } from './destroy-component/destroy-component';


@Component({
  selector: 'app-root',
  imports: [DestroyComponent],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
   age: string = '23';
}
