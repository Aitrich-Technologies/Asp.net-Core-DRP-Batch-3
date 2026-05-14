using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise2.Models;

namespace Excercise2
{
public class DisplayList
    {
        public static void ShowProfile(User user)
        {
            Console.WriteLine("\n===== MY PROFILE =====");

            Console.WriteLine($"ID         : {user.Id}");
            Console.WriteLine($"First Name : {user.FirstName}");
            Console.WriteLine($"Last Name  : {user.LastName}");
            Console.WriteLine($"Email      : {user.Email}");
            Console.WriteLine($"Mobile     : {user.Phone}");
            Console.WriteLine($"Role       : {user.Role}");

            Console.WriteLine("======================\n");
        }

        public static void ShowConsultants(List<User> consultants)
        {
            if (consultants.Count == 0)
            {
                Console.WriteLine("No consultants available.");
                return;
            }

            Console.WriteLine("\n===== CONSULTANT LIST =====");

            foreach (var c in consultants)
            {
                Console.WriteLine($"ID         : {c.Id}");
                Console.WriteLine($"First Name : {c.FirstName}");
                Console.WriteLine($"Last Name  : {c.LastName}");
                Console.WriteLine($"Email      : {c.Email}");
                Console.WriteLine($"Mobile     : {c.Phone}");
                Console.WriteLine($"Role       : {c.Role}");
                Console.WriteLine("----------------------------");
            }
        }

        public static void ShowTours(List<Tour> tours)
        {
            if (tours.Count == 0)
            {
                Console.WriteLine("No tours available.");
                return;
            }

            Console.WriteLine("\n===== TOUR LIST =====");

            int count = 1;

            foreach (var t in tours)
            {
                Console.WriteLine($"{count++}. {t.Destination} - {t.Days} Days - ₹{t.Price}");
            }
        }

        public static void ShowDestinations(List<Destination> list)
        {
            if (list.Count == 0)
            {
                Console.WriteLine("No destinations found.");
                return;
            }

            Console.WriteLine("\n===== DESTINATIONS =====");

            foreach (var d in list)
            {
                Console.WriteLine($"ID: {d.Id}");
                Console.WriteLine($"Name: {d.Name}");
                Console.WriteLine($"Description: {d.Description}");
                Console.WriteLine("------------------------");
            }
        }

    }
}
    

