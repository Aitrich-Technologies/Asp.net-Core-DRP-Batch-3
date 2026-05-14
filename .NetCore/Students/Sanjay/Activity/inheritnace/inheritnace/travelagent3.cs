using System;
using System.Collections.Generic;
using System.Text;

namespace inheritnace
{
    internal class travelagent3 : employee3
    {
        public string bookingSystem;
        public string customerHandling;

        public override void GetInfo()
        {
            base.GetInfo();

            Console.Write("Enter Booking System Knowledge: ");
            bookingSystem = Console.ReadLine();

            Console.Write("Enter Customer Handling Skills: ");
            customerHandling = Console.ReadLine();
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Role: Travel Agent");
            Console.WriteLine("Booking System: ");
            Console.WriteLine("Customer Handling: ");
        }
    }
}
