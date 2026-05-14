using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_activity
{
    internal class Domestictour:Tour
    {
        public override void ShowDetails()
        {
            Console.WriteLine("Domestic Tour:");
            Console.WriteLine("Tour Name: " + tourName);
            Console.WriteLine("Destination: " + destination);
        }
    }
}
