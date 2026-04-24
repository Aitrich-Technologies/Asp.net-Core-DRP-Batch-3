using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding_activity
{
    internal class Booking
    {
        public virtual void confirmBooking()
        {
            Console.WriteLine("Booking confirmed");
        }
    }
}
