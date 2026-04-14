using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static bool found;

        struct Car
        {
            public int Carid;
            public string Model;
            public bool IsAvailable;
        }
        static void Main(string[] args)
        {
            Car[] cars = new Car[3];

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Enter details for Car " + (i + 1));

                Console.Write("Enter Car ID: ");
                cars[i].Carid = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter  model:");
                cars[i].Model = Console.ReadLine();

                Console.Write("Is Available (true/false): ");
                cars[i].IsAvailable = Convert.ToBoolean(Console.ReadLine());

               Console.WriteLine();

                Console.Write("Enter Car ID to search: ");
                int searchID = Convert.ToInt32(Console.ReadLine());

                for (int j = 0; j < cars.Length; j++)
                {
                    if (cars[j].Carid == searchID)
                    {
                        Console.WriteLine("Car Found!");
                        Console.WriteLine("Model: " + cars[j].Model);

                        if (cars[i].IsAvailable)
                            Console.WriteLine("Status: Available");
                        else
                            Console.WriteLine("Status: Not Available");

                        found = true;
                        break;
                    }
                }

                
                if (!found)
                {
                    Console.WriteLine("Car not found!");
                }














            }
        }
    }
}