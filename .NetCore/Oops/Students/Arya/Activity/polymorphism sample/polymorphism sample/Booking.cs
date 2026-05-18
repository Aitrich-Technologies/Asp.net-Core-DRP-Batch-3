using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_sample
{
    internal class Booking:Tour
    {
        public override void addtour()
        {
            Console.WriteLine("tour booked");
        }
    }
}
