import { Injectable } from '@angular/core';
import { Booking } from '../models/booking.model';

@Injectable({
  providedIn: 'root'
})
export class BookingService {

  private bookings: Booking[] = [
    {
      id: 1,
      customerName: 'Amit Sharma',
      destination: 'Goa',
      tourPackage: 'Goa Beach Escape',
      bookingDate: '2025-09-01',
      travelDate: '2025-10-15',
      status: 'Confirmed',
      amount: 25000,
      email: 'amit.sharma@example.com',
      phone: '9876543210',
      numberOfTravellers: 2
    },
    {
      id: 2,
      customerName: 'Priya Nair',
      destination: 'Kerala',
      tourPackage: 'Backwater Bliss',
      bookingDate: '2025-08-20',
      travelDate: '2025-11-05',
      status: 'Pending',
      amount: 32000,
      email: 'priya.nair@example.com',
      phone: '9123456780',
      numberOfTravellers: 4
    },
    {
      id: 3,
      customerName: 'Rahul Verma',
      destination: 'Manali',
      tourPackage: 'Snow Adventure',
      bookingDate: '2025-07-10',
      travelDate: '2025-12-20',
      status: 'Cancelled',
      amount: 18000,
      email: 'rahul.verma@example.com',
      phone: '9988776655',
      numberOfTravellers: 1
    },
    {
      id: 4,
      customerName: 'Sneha Iyer',
      destination: 'Rajasthan',
      tourPackage: 'Royal Desert Tour',
      bookingDate: '2025-09-05',
      travelDate: '2025-10-30',
      status: 'Confirmed',
      amount: 40000,
      email: 'sneha.iyer@example.com',
      phone: '9090909090',
      numberOfTravellers: 3
    }
  ];

  getBookings(): Booking[] {
    return this.bookings;
  }

  getBookingById(id: number): Booking | undefined {
    return this.bookings.find(b => b.id === id);
  }

  searchByCustomerName(name: string): Booking[] {
    if (!name?.trim()) {
      return this.bookings;
    }
    const term = name.toLowerCase();
    return this.bookings.filter(b =>
      b.customerName.toLowerCase().includes(term)
    );
  }
}
