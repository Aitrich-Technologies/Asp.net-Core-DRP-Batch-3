using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverloading_activity
{
    internal class Booking
    {
        public void Book(int seats)
        {
            Console.WriteLine("Booked Seats: " + seats);
        }

        public void Book(int seats, string name)
        {
            Console.WriteLine("Booked " + seats + " seats for " + name);
        }
    }
}
