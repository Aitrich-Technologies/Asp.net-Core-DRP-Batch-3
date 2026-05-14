using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_activity
{
    internal class Deluxeroom:Hotel
    {
        public override void Bookroom()
        {

            Console.WriteLine("Deluxe Room booked at " + Hotelname);
        }
    }
}
