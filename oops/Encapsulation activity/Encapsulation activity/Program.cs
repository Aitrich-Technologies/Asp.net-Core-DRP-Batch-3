using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tour t = new Tour();
            t.Settourname("ALFIN", "kerala", 2000);
            Console.WriteLine(t.Gettourname());

            //Booking b = new Booking();
            //b.setBooking("Arya","paris", 2);
            //Console.WriteLine(b.getBooking());
        }
    }
}
