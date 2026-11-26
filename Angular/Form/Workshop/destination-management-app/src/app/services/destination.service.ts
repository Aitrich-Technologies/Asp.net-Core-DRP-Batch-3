import { Injectable } from '@angular/core';
import { Destination } from '../models/destination.model';

@Injectable({
  providedIn: 'root'
})
export class DestinationService {

  destinations: Destination[] = [
    {
      id: 1,
      name: 'Baga Beach',
      country: 'India',
      description: 'A vibrant beach known for water sports and nightlife.',
      startingPrice: 15000,
      rating: 4.5,
      imageUrl: 'https://images.unsplash.com/photo-1512343879784-a960bf40e7f2'
    },
    {
      id: 2,
      name: 'Eiffel Tower',
      country: 'France',
      description: 'Iconic iron lattice tower in the heart of Paris.',
      startingPrice: 85000,
      rating: 4.8,
      imageUrl: 'https://images.unsplash.com/photo-1502602898657-3e91760cbb34'
    },
    {
      id: 3,
      name: 'Santorini',
      country: 'Greece',
      description: 'Famous for whitewashed villages and stunning sunsets.',
      startingPrice: 65000,
      rating: 4.9,
      imageUrl: 'https://images.unsplash.com/photo-1533105079780-92b9be482077'
    }
  ];

  private nextId = 4;

  // Simple string the list page reads after add/edit/delete
  successMessage = '';

  getAll(): Destination[] {
    return this.destinations;
  }

  getById(id: number): Destination | undefined {
    return this.destinations.find(d => d.id === id);
  }

  add(destination: Destination): void {
    destination.id = this.nextId++;
    this.destinations.push(destination);
    this.successMessage = `Destination "${destination.name}" added successfully.`;
  }

  update(destination: Destination): void {
    const index = this.destinations.findIndex(d => d.id === destination.id);
    if (index > -1) {
      this.destinations[index] = destination;
      this.successMessage = `Destination "${destination.name}" updated successfully.`;
    }
  }

  delete(id: number): void {
    const destination = this.getById(id);
    this.destinations = this.destinations.filter(d => d.id !== id);
    if (destination) {
      this.successMessage = `Destination "${destination.name}" deleted successfully.`;
    }
  }

  search(term: string): Destination[] {
    if (!term) return this.destinations;
    const lower = term.toLowerCase();
    return this.destinations.filter(d =>
      d.name.toLowerCase().includes(lower) ||
      d.country.toLowerCase().includes(lower)
    );
  }
}
