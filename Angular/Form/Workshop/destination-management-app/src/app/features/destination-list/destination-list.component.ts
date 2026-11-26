import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { Router, RouterLink } from '@angular/router';
import { Destination } from '../../models/destination.model';
import { DestinationService } from '../../services/destination.service';

@Component({
  selector: 'app-destination-list',
  standalone: true,
  imports: [FormsModule, CommonModule, RouterLink],
  templateUrl: './destination-list.component.html',
  styleUrl: './destination-list.component.css'
})
export class DestinationListComponent implements OnInit {

  destinations: Destination[] = [];
  searchTerm = '';
  successMessage = '';

  constructor(
    private destinationService: DestinationService,
    private router: Router
  ) {}

  ngOnInit(): void {
    this.loadDestinations();
    this.showSuccessMessageIfAny();
  }

  loadDestinations(): void {
    this.destinations = this.destinationService.search(this.searchTerm);
  }

  showSuccessMessageIfAny(): void {
    if (this.destinationService.successMessage) {
      this.successMessage = this.destinationService.successMessage;
      this.destinationService.successMessage = '';
      setTimeout(() => (this.successMessage = ''), 3000);
    }
  }

  onEdit(id: number): void {
    this.router.navigate(['/destinations/edit', id]);
  }

  onDelete(id: number, name: string): void {
    if (confirm(`Delete "${name}"?`)) {
      this.destinationService.delete(id);
      this.loadDestinations();
      this.showSuccessMessageIfAny();
    }
  }
}
