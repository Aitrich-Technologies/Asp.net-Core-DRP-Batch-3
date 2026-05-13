using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_activity
{
    internal class Internationaltour:Tour
    {
        public override void ShowDetails()
        {
            Console.WriteLine("International Tour:");
            Console.WriteLine("Tour Name: " + tourName);
            Console.WriteLine("Destination: " + destination);
        }

    }
}
