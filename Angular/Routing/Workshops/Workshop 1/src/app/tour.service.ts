import { Injectable } from '@angular/core';
import { Tour } from './tour';

@Injectable({
  providedIn: 'root',
})
export class TourService {
  tours: Tour[] = [
    {
      id: 1,
      name: 'Dubai',
      country: 'UAE',
      price: 1500,
      image:
        'https://images.unsplash.com/photo-1512453979798-5ea266f8880c?auto=format&fit=crop&w=700&q=80',
      description: 'Luxury city tour',
    },

    {
      id: 2,
      name: 'Switzerland',
      country: 'Switzerland',
      price: 2500,
      image:
        'https://images.unsplash.com/photo-1530122037265-a5f1f91d3b99?auto=format&fit=crop&w=700&q=80',
      description: 'Snow mountains',
    },

    {
      id: 3,
      name: 'Paris',
      country: 'France',
      price: 2200,
      image:
        'https://images.unsplash.com/photo-1502602898657-3e91760cbb34?auto=format&fit=crop&w=700&q=80',
      description: 'City of love',
    },
  ];

  getTours() {
    return this.tours;
  }

  getTour(id: number) {
    return this.tours.find((x) => x.id == id);
  }
}
