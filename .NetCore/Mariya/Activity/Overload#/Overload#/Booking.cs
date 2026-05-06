using System;
using System.Collections.Generic;
using System.Text;

namespace Overload_
{
    internal class Booking
    {
        public void Book(int seats)
        {
            Console.WriteLine($"Booked {seats} seats");
        }

        // Method 2 (Overloaded)
        public void Book(int seats, string name)
        {
            Console.WriteLine($"Booked {seats} seats for {name}");
        }
    }
}
