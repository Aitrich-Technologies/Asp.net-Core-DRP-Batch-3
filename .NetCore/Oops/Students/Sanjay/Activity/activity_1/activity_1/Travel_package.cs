using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_1
{
    internal class Travel_package
    {
        public int packageId;
        public string packageName;
        public double price;

        public Travel_package(int id, string name, double price)
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
