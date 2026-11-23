import { Component, signal } from '@angular/core';
import { Header } from './header/header';
import { Card } from './card/card';
import { Banner } from './banner/banner';
import { Footer } from './footer/footer';

@Component({
  selector: 'app-root',
  imports: [Header,Card,Banner,Footer],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('Workshop');
}
