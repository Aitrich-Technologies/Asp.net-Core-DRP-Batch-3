using Encapsulation_activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tour t = new Tour();
            t.Settourname("ALFIN", "kerala", 2000);
            Console.WriteLine(t.Gettourname());

            Booking b = new Booking();
            b.setBooking("Arya","paris", 2);
            Console.WriteLine(b.getBooking());

            TourPackage tp = new TourPackage();
            tp.setpackage("Family Package", 2);
           Console.WriteLine( tp.getpackage());

            Payment p = new Payment();
            p.setamount(5000);
            Console.WriteLine(" Payment Details");
            Console.WriteLine(p.getamount());



        }
    }
}
