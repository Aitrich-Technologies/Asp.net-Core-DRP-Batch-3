import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, RouterLink } from '@angular/router';
import { Location, CommonModule } from '@angular/common';
import { Booking } from '../../models/booking.model';
import { BookingService } from '../../services/booking.service';

@Component({
  selector: 'app-booking-details',
  standalone: true,
  imports: [RouterLink, CommonModule],
  templateUrl: './booking-details.component.html',
  styleUrl: './booking-details.component.css'
})
export class BookingDetailsComponent implements OnInit {

  booking?: Booking;

  constructor(
    private route: ActivatedRoute,
    private bookingService: BookingService,
    private location: Location
  ) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe(params => {
      const id = Number(params.get('id'));
      this.booking = this.bookingService.getBookingById(id);
    });
  }

  goBack(): void {
    this.location.back();
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
