using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_activity
{
    internal class Standardroom:Hotel
    {
        public override void Bookroom()
        {
            
            Console.WriteLine("Standard Room booked at " + Hotelname);
            Console.WriteLine("Location: " + location);
        }
    }
}
