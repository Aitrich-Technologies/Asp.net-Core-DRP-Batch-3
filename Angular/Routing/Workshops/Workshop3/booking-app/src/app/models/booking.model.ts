export interface Booking {
  id: number;
  customerName: string;
  destination: string;
  tourPackage: string;
  bookingDate: string;
  travelDate: string;
  status: 'Confirmed' | 'Pending' | 'Cancelled';
  amount: number;
  email: string;
  phone: string;
  numberOfTravellers: number;
}
