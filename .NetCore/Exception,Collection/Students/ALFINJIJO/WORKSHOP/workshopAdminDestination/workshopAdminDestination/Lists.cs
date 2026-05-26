using System;
using System.Collections.Generic;
using System.Text;
using workshopAdminDestination.Models;

namespace workshopAdminDestination
{
    
    
        public class Lists
        {
            public void PrintAdmins(List<User> admins)
            {
                Console.WriteLine("\nAdmins:\n");
                Console.WriteLine("{0,-10}|{1,-20}|{2,-30}", "Id", "Name", "Email");

                foreach (var admin in admins)
                {
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("{0,-10}|{1,-20}|{2,-30}",
                        admin.Id, admin.FirstName, admin.Email);
                }
                Console.WriteLine();
            }

            public void PrintTours(List<Tour> tours)
            {
                Console.WriteLine("\nTour Destinations:\n");
                Console.WriteLine("{0,-10}|{1,-25}|{2,-10}|{3,-10}",
                    "TourId", "Destination", "Days", "Price");

                foreach (var tour in tours)
                {
                    Console.WriteLine("---------------------------------------------------------------");
                    Console.WriteLine("{0,-10}|{1,-25}|{2,-10}|{3,-10}",
                        tour.Id, tour.Destination, tour.Days, tour.Price);
                }
                Console.WriteLine();
            }
        }
    
}
