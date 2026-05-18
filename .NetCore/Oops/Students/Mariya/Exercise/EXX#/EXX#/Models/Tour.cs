using System;
using System.Collections.Generic;
using System.Text;

namespace EXX_.Models
{
    public class Tour
    {
        public int TourId { get; set; }
        public string Destination { get; set; }
        public decimal Price { get; set; }
        public int AvailableSeats { get; set; }

        public void Display()
        {
            Console.WriteLine($"ID: {TourId} | Destination: {Destination} | Price: {Price} | Seats: {AvailableSeats}");
        }

    }
}
