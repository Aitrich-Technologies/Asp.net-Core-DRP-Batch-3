using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Lists
    {
        public void PrintTours(List<Tour> tours)
        {
            Console.WriteLine("\nAvailable Tours\n");

            Console.WriteLine
            (
                "{0,-10}|{1,-20}|{2,-10}|{3,-10}",
                "Id",
                "Destination",
                "Days",
                "Price"
            );

            foreach (var item in tours)
            {
                Console.WriteLine
                (
                    "{0,-10}|{1,-20}|{2,-10}|{3,-10}",
                    item.Id,
                    item.Destination,
                    item.Days,
                    item.Price
                );
            }
        }

        public void PrintProfile(User user)
        {
            Console.WriteLine("\nUser Profile\n");

            Console.WriteLine("Id : " + user.Id);

            Console.WriteLine("Name : " + user.Name);

            Console.WriteLine("Email : " + user.Email);
        }
    }
}

