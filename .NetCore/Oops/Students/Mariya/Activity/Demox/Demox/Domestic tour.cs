using System;
using System.Collections.Generic;
using System.Text;

namespace Demox
{
    internal class Domestictour:Tour
    {
        public override void ShowDetails()
        {
            Console.WriteLine("Domestic Tour Details:");
            Console.WriteLine("Tour Name: " + TourName);
            Console.WriteLine("Destination: " + Destination);
            Console.WriteLine("Note: This is a domestic tour within the country.");
        }
    }
}
