using System;
using System.Collections.Generic;
using System.Text;
using workshopAdminDestination.Interface;

namespace workshopAdminDestination.Manager
{
    
        public class CustomerManager : IMenu
        {
            public void DisplayMenu()
            {
                Console.WriteLine("1.View Tours\n2.Book Tour\n3.Logout");
                Console.WriteLine("Booking feature can be extended...");
            }
        }

    
}
