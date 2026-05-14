using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise1.Models;

namespace Excercise1
{
    public class DisplayDetails
    {
        public void ShowUserProfile(User user)
        {
            Console.WriteLine("\n----- USER PROFILE -----");
            Console.WriteLine($"Id: {user.Id}");
            Console.WriteLine($"Name: {user.FirstName} {user.LastName}");
            Console.WriteLine($"Email: {user.Email}");
            Console.WriteLine($"Phone: {user.Phone}");
        }

        public void ShowTours(List<Tour> tours)
        {
            Console.WriteLine("\n----- TOUR LIST -----");

            if (tours.Count == 0)
            {
                Console.WriteLine("No Tours Available.");
                return;
            }

            foreach (var tour in tours)
            {
                Console.WriteLine($"Id: {tour.Id}");
                Console.WriteLine($"Destination: {tour.Destination}");
                Console.WriteLine($"Days: {tour.Days}");
                Console.WriteLine($"Price: {tour.Price}");
                Console.WriteLine("---------------------------");
            }
        }
    }
}
