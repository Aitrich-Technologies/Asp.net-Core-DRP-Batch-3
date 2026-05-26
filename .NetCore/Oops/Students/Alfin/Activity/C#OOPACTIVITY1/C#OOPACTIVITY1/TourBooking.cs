using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOPACTIVITY1
{
    internal class TourBooking
    {
       public string customerName;
       public string tourPackage;
       public int totalCost;

        public TourBooking(string name, string package, int cost)
        {
            customerName = name;
            tourPackage = package;
            totalCost = cost;
        }

        public void Display()
        {
            Console.WriteLine(customerName);
            Console.WriteLine(tourPackage);
            Console.WriteLine(totalCost);
        }
    }
}
