using System;
using System.Collections.Generic;
using System.Text;

namespace Demox
{
    internal class Internationaltour:Tour
    {
        public override void ShowDetails()
        {
            Console.WriteLine("International Tour Details:");
            Console.WriteLine("Tour Name: " + TourName);
            Console.WriteLine("Destination: " + Destination);
            Console.WriteLine("Note: Passport and visa are required for this international tour.");
        }
    }
}
