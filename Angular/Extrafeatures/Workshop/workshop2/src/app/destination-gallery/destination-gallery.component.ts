import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DestinationCardComponent } from '../destination-card/destination-card.component';

export interface Destination {
  id: number;
  name: string;
  country: string;
  image: string;
  price: number;
  rating: number;
}

@Component({
  selector: 'app-destination-gallery',
  standalone: true,
  imports: [CommonModule, DestinationCardComponent],
  templateUrl: './destination-gallery.component.html',
  styleUrls: ['./destination-gallery.component.css'],
})
export class DestinationGalleryComponent {
  currentDestination = '';

  destinations: Destination[] = [
    {
      id: 1,
      name: 'Switzerland',
      country: 'Europe',
      image: 'https://images.unsplash.com/photo-1506744038136-46273834b3fb',
      price: 2500,
      rating: 4.9,
    },

    {
      id: 2,
      name: 'Maldives',
      country: 'Asia',
      image: 'https://images.unsplash.com/photo-1507525428034-b723cf961d3e',
      price: 1800,
      rating: 4.8,
    },

    {
      id: 3,
      name: 'Paris',
      country: 'France',
      image: 'https://images.unsplash.com/photo-1499856871958-5b9627545d1a',
      price: 2200,
      rating: 4.7,
    },
  ];

  showDetails(id: number) {
    const selected = this.destinations.find((d) => d.id === id);

    if (selected) {
      this.currentDestination = selected.name;
    }
  }
}
