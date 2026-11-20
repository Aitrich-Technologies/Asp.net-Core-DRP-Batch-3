import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute, RouterLink } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { Booking } from '../../models/booking.model';
import { BookingService } from '../../services/booking.service';

@Component({
  selector: 'app-booking-list',
  standalone: true,
  imports: [FormsModule, RouterLink, CommonModule],
  templateUrl: './booking-list.component.html',
  styleUrl: './booking-list.component.css'
})
export class BookingListComponent implements OnInit {

  allBookings: Booking[] = [];
  filteredBookings: Booking[] = [];
  searchTerm = '';

  constructor(
    private bookingService: BookingService,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    this.allBookings = this.bookingService.getBookings();

    // Restore search term from query params (on refresh / deep link)
    this.route.queryParamMap.subscribe(params => {
      const q = params.get('search') || '';
      this.searchTerm = q;
      this.filteredBookings = this.bookingService.searchByCustomerName(q);
    });
  }

  onSearch(): void {
    // Update URL with query param without reloading the component
    this.router.navigate([], {
      relativeTo: this.route,
      queryParams: { search: this.searchTerm || null },
      queryParamsHandling: 'merge'
    });
  }

  clearSearch(): void {
    this.searchTerm = '';
    this.onSearch();
  }

  getStatusClass(status: string): string {
    switch (status) {
      case 'Confirmed': return 'badge bg-success';
      case 'Pending': return 'badge bg-warning text-dark';
      case 'Cancelled': return 'badge bg-danger';
      default: return 'badge bg-secondary';
    }
  }
}
