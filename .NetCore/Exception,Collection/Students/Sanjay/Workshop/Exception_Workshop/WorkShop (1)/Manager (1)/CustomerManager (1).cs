using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin_Destination.Interface;

namespace Admin_Destination.Manager
{
public class CustomerManager:IMenu
    {
        public void DisplayMenu()
        {
            Console.WriteLine("1.View Tours\n2.Book Tour\n3.Logout");
            Console.WriteLine("Booking feature can be extended...");
        }
    }
}

