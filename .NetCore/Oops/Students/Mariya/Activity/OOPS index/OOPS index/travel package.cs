using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS_index
{
    internal class travel_package
    {
        public int packageId;
        public string packageName;
        public double price;

        public travel_package(int id, string name, double price)
        {
            packageId = id;
            packageName = name;
            this.price = price;

        }
        public void Display()
        {
            Console.WriteLine("Package ID: " + packageId);
            Console.WriteLine("Package Name: " + packageName);
            Console.WriteLine("Price: " + price);
        }
    }
}
