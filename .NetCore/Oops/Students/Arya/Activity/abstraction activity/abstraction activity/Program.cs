using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tour t1 = new Internationaltour() 
            { tourName = "Kerala Trip", destination = "Munnar" };
            t1.ShowDetails();

            Payment p = new Upipayment();
            p.Makepayment();

            Tourpackage pkg = new Luxurypackage()
            { Baseprice = 10000 };
            Console.WriteLine("Total Price: " + pkg.CalculatePrice());

            Transport tr = new Flight();
            tr.Travel();

            Hotel h = new Standardroom() 
            { Hotelname = "Taj Hotel",
            location = "kochi"};
            h.Bookroom();

            Guide g = new Adventureguide();
            { g.Explainplace(); }
        }
    }
}
