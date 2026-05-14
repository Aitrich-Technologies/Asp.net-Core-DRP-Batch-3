using System;
using System.Collections.Generic;
using System.Text;

namespace inheritnace
{
    internal class tourpackage
    {
        public int packageId;
        public string location;
        public double price;

        public void GetDetails()
        {
            Console.Write("Enter Package ID: ");
            packageId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Location: ");
            location = Console.ReadLine();

            Console.Write("Enter Price: ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        public void ShowDetails()
        {
            Console.WriteLine("\nPackage ID: " + packageId);
            Console.WriteLine("Location: " + location);
            Console.WriteLine("Price: " + price);
        }


        public virtual void DisplayPackageType()
        {
            Console.WriteLine("General Tour Package");
        }

    }
}
