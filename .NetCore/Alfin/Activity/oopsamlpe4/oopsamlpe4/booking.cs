using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace oopsamlpe4
{
    internal class booking
    {
        private string customerName;
        private string tourName;
        private int seats;

        public void SetCustomerName(string name)
        {
            customerName = name;
        }

        public void SetTourName(string tour)
        {
            tourName = tour;
        }

        public void SetSeats(int seat)
        {
            if (seat > 0)
            {
                seats = seat;
            }
            //else
            //{
            //    Console.WriteLine("Invalid seats! Must be greater than 0.");
            //}
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
        public void ShowBooking()
        {
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Tour Name: " + tourName);
            Console.WriteLine("Seats: " + seats);
        }


    }
}



