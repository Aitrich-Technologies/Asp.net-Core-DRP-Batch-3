using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_1loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            tours t = new tours();
            t.Disply();

            
                tourist t1 = new tourist(1, "Arya", 22);
                t1.Display();
            

            
                Travel_package p = new Travel_package(10, "japan tour", 150000);
                p.Display();
            

            
                Hotel h = new Hotel("Taj Hotel", "Kochi", 5000);
                h.Display();
            
            
                Bus b = new Bus(5, "Kochi", "Trivandrum");
                b.Display();

            Ticket a = new Ticket(100, "sanjay", 1000);
            a.Display();

            Guide g = new Guide(1, "Alfin", 5);
            g.Display();


            Tourbooking tb = new Tourbooking("Anjitha", "paris Tour", 20000);
            tb.Display();
        }


    }
}
