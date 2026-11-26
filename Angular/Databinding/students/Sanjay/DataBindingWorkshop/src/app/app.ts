import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Header } from './header/header';
import { Footer } from './footer/footer';
import { Consultant } from './consultant/consultant';

@Component({
  selector: 'app-root',
  imports: [Header,Footer,Consultant],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('DataBindingWorkshop');
}
