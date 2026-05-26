using ExerciseException1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseException1
{
    public class List
    {
        public static void ShowProfile(User user)
        {
            Console.WriteLine("---------- MY PROFILE ----------");

            Console.WriteLine($"ID         : {user.Id}");
            Console.WriteLine($"First Name : {user.FirstName}");
            Console.WriteLine($"Last Name  : {user.LastName}");
            Console.WriteLine($"Email      : {user.Email}");
            Console.WriteLine($"Mobile     : {user.Phone}");
            Console.WriteLine($"Role       : {user.Roles}");

            Console.WriteLine("---------------------------");
        }

        public static void ShowConsultants(List<User> consultants)
        {
            if (consultants.Count == 0)
            {
                Console.WriteLine("No consultants available.");
                return;
            }

            Console.WriteLine("------CONSULTANT DETAILS -----");

            foreach (var i in consultants)
            {
                Console.WriteLine($"ID         : {i.Id}");
                Console.WriteLine($"First Name : {i.FirstName}");
                Console.WriteLine($"Last Name  : {i.LastName}");
                Console.WriteLine($"Email      : {i.Email}");
                Console.WriteLine($"Mobile     : {i.Phone}");
                Console.WriteLine($"Role       : {i.Roles}");
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

            Console.WriteLine("--------- TOUR DETAILS ---------");

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

            Console.WriteLine("---------- DESTINATION DETAILS -----------");

            foreach (var i in list)
            {
                Console.WriteLine($"ID          : {i.Id}");
                Console.WriteLine($"Name        : {i.Name}");
                Console.WriteLine($"Description : {i.Description}");
                Console.WriteLine("------------------------");
            }
        }
    }
}
