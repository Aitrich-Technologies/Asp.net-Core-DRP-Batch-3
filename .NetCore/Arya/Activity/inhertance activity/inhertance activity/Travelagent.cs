using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhertance_activity
{
    internal class Travelagent:Employee
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
