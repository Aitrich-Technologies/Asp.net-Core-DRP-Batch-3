using System;
using System.Collections.Generic;
using System.Text;

namespace ENS
{
    internal class Booking
    {
        private string customerName;
        private string tourName;
        private int seats;

       
        public Booking(string customerName, string tourName, int seats)
        {
            this.customerName = customerName;
            this.tourName = tourName;
            SetSeats(seats);
        }

       
        public void SetSeats(int seats)
        {
            if (seats > 0)
            {
                this.seats = seats;
            }
            else
            {
                throw new ArgumentException("Seats must be greater than 0");
            }
        }

        public string GetCustomerName()
        {
            return customerName;
        }

        public string GetTourName()
        {
            return tourName;
        }

        public int GetSeats()
        {
            return seats;
        }
    }
}
