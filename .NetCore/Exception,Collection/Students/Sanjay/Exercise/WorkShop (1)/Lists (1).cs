using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin_Destination.Models;

namespace Admin_Destination
{
  public class Lists
    {
        public void PrintAdmins(User[] users)
        {
            Console.WriteLine("\nAdmins:\n");
            Console.WriteLine("{0,-10}|{1,-20}|{2,-30}", "Id", "Name", "Email");

            foreach (var admin in users)
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

        public void PrintBooking(Booking[] bookings)
        {
            Console.WriteLine("\n========== My Bookings ==========\n");

            Console.WriteLine("{0,-10}|{1,-20}|{2,-25}",
                "BookingId",
                "TourId",
                "Destination");

            foreach (var booking in bookings)
            {
                if (booking != null)
                {
                    Console.WriteLine("------------------------------------------------");

                    Console.WriteLine("{0,-10}|{1,-20}|{2,-25}",
                        booking.BookingId,
                        booking.TourId,
                        booking.Destination);
                }
            }

            Console.WriteLine();
        }
    }
}

    

