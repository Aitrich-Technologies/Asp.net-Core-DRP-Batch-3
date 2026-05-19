using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //jobseeker s = new jobseeker();

            //s.email = "aryava225@gmail.com";
            //s.Login();
            //s.Applyjob();
            //Console.WriteLine(s.email);

            domestictour d = new domestictour();
            d.tourname = "solotrip";
            d.destination = "korea";
            d.price = 50000;
            Console.WriteLine($"{d.tourname}  {d.destination} {d.price}");
            d.Display();
            d.display();



            

        }
    }
}
