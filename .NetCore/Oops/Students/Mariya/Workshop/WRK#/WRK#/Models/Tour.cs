using System;
using System.Collections.Generic;
using System.Text;

namespace WRK_.Models
{
    //internal class Tour
    //{
        public class Tour
        {
            public int TourId { get; set; }
            public int Destination { get; set; }
            public int AvailableSeats { get; set; }

            public void Display()
            {
                Console.WriteLine($"ID:{TourId} | Destination :{Destination} | Seats: {AvailableSeats}");
            }
        }
    }

