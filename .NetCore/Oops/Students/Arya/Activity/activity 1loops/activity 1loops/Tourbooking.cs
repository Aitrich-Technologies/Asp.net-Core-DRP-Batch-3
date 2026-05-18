using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_1loops
{
    internal class Tourbooking
    {

       public string customerName;
       public string tourPackage;
       public double totalCost;

        public Tourbooking(string name, string package, double cost)
        {
            customerName = name;
            tourPackage = package;
            totalCost = cost;
        }
        public void Display()
        {
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Tour Package: " + tourPackage);
            Console.WriteLine("Total Cost: " + totalCost);
        }
    }
}

