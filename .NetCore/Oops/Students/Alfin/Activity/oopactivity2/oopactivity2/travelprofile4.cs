using System;
using System.Collections.Generic;
using System.Text;

namespace oopactivity2
{
    internal class travelprofile4
    {
        public string name;
        public string travelHistory;

        public virtual void GetDetails()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Travel History: ");
            travelHistory = Console.ReadLine();
        }

        public virtual void DisplayProfile()
        {
            Console.WriteLine("\nName: ");
            Console.WriteLine("Travel History: ");
        }
    }
}

