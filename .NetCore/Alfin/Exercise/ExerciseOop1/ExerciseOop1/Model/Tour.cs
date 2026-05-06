using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseOop1.Model
{
    public  class Tour
    {
        public int TourId { get; set; }
        public string Destination { get; set; }
        public int Price { get; set; }
        public int AvailableSeats { get; set; }

        public void Display()
        {
            Console.WriteLine($"ID:{TourId} | Destination :{Destination} | Seats: {AvailableSeats}");
        }

    }
}
