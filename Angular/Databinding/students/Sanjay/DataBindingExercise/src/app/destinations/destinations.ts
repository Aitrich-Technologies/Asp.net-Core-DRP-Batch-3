
import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-destinations',
  imports: [CommonModule, FormsModule],
  templateUrl: './destinations.html',
  styleUrl: './destinations.css',
})
export class Destinations {

  dashboardHeading = "Explore Destinations";

  search = "";

  destination = [
    {
      Id: 1,
      destinationName: "Bali",
      description: "Beautiful beaches and tropical paradise.",
      startingPrice: 2000,
      image: "bali.jpg",
      Status: "Popular",
    },
    {
      Id: 2,
      destinationName: "Maldives",
      description: "Explore beautiful islands and clear waters.",
      startingPrice: 4000,
      image: "maldives.jpg",
      Status: "Trending",
    },
    {
      Id: 3,
      destinationName: "Dubai",
      description: "Experience luxury shopping and desert safari.",
      startingPrice: 5000,
      image: "Dubai.jpg",
      Status: "Trending",
    },
    {
      Id: 4,
      destinationName: "Singapore",
      description: "Discover amazing attractions and city life.",
      startingPrice: 7000,
      image: "Singapore.jpg",
      Status: "New",
    },
  ];

  get searchDestinations() {
    return this.destination.filter(d =>
      d.destinationName.toLowerCase().includes(this.search.toLowerCase())
    );
  }

  selectedDestinationId: number | null = null;

  selectDestination(id: number) {
    this.selectedDestinationId = id;
  }

  getPriceStyle(price: number) {

    if (price <= 2000) {
      return { 'background-color': '#d1e7dd' };
    }
    else if (price <= 5000) {
      return { 'background-color': '#fff3cd' };
    }
    else {
      return { 'background-color': '#f8d7da' };
    }

  }

  selectedDestination: (typeof this.destination)[number] | null = null;

  viewDetails(item: (typeof this.destination)[number]) {
    this.selectedDestination = item;
    this.selectedDestinationId = item.Id;
  }

}
