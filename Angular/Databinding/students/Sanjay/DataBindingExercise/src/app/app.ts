import { Component, signal } from '@angular/core';
import { Destinations } from './destinations/destinations';

@Component({
  selector: 'app-root',
  imports: [Destinations],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('DataBindingExercise');
}
