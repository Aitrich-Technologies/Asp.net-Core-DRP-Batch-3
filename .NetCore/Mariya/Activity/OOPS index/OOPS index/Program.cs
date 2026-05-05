using System.Net.Sockets;

namespace OOPS_index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            tour tours = new tour();
            tours.location = "Maldives";
            tours.activities = "firework";
            tours.spot = 5;

            tours.display();
            {
                Console.WriteLine(tours.location);
                Console.WriteLine(tours.activities);
                Console.WriteLine(tours.spot);
            }


            tourist t1 = new tourist(1, "Arya", 22);
            t1.Display();



            travel_package p = new travel_package(10, "japan tour", 150000);
            p.Display();



            Hotel h = new Hotel("Taj Hotel", "Kochi", 5000);
            h.Display();


            Bus b = new Bus(5, "Kochi", "Trivandrum");
            b.Display();

            //Ticket a = new Ticket(100, "sanjay", 1000);
            //a.Display();

            guide g = new guide(1, "Alfin", 5);
            g.Display();


            //tourbooking tb = new Tourbooking("Anjitha", "paris Tour", 20000);
            //tb.Display();
        }

    }
}
}

