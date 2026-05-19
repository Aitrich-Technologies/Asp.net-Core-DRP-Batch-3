using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_index
{
    internal class tour
    {
        public string location;
        public string activities;
        public int spot;


        public tour()
        {
            location= "Maldives";
            activities= "firework";
            spot= 5;
        }

        public void display()
        {
            Console.WriteLine("tour details");

            Console.WriteLine(location);
            Console.WriteLine(activities);
            Console.WriteLine(spot);


        }
    }
}
