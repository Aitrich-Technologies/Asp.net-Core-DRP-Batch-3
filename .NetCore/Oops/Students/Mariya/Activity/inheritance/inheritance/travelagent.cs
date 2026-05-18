using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    internal class travelagent:Employee
    {
        public string bookingsystem;
        public string customerhandling;

        public void showagentdetails()
        {
            Console.WriteLine("Booking system:" + bookingsystem);
            Console.WriteLine("Customer Handling:" + customerhandling);
        }
    }
}
