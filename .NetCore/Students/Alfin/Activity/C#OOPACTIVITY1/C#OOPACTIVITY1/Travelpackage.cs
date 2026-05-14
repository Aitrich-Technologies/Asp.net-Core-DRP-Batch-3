using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOPACTIVITY1
{
    internal class Travelpackage
    {
       public int packageId;
       public string packageName;
       public int price;

        public Travelpackage(int id, string name, int p)
        {
            packageId = id;
            packageName = name;
            price = p;
        }

        public void Display()
        {
            Console.WriteLine(packageId);
            Console.WriteLine(packageName);
            Console.WriteLine(price);
        }
    }
}
