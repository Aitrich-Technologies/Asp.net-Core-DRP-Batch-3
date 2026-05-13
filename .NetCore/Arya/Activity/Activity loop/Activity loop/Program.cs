using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            List<Customer> customers = new List<Customer>();

            int choice;

            do
            {
                Console.WriteLine("\n1. Add Vehicle");
                Console.WriteLine("2. Register Customer");
                Console.WriteLine("3. Rent Vehicle");
                Console.WriteLine("4. Display Customers");
                Console.WriteLine("5. Exit");

                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter type (Car/Bike): ");
                        string type = Console.ReadLine();

                        Console.Write("Make: ");
                        string make = Console.ReadLine();

                        Console.Write("Model: ");
                        string model = Console.ReadLine();

                        Console.Write("Year: ");
                        int year = int.Parse(Console.ReadLine());

                        Console.Write("Reg No: ");
                        string reg = Console.ReadLine();

                        if (type.ToLower() == "car")
                        {
                            Console.Write("Seats: ");
                            int seats = int.Parse(Console.ReadLine());
                            vehicles.Add(new Car(make, model, year, reg, seats));
                        }
                        else
                        {
                            Console.Write("Has Carrier (true/false): ");
                            bool carrier = bool.Parse(Console.ReadLine());
                            vehicles.Add(new Bike(make, model, year, reg, carrier));
                        }

                        Console.WriteLine("Vehicle Added!");
                        break;

                    case 2:
                        Console.Write("Customer ID: ");
                        string cid = Console.ReadLine();

                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Contact: ");
                        string contact = Console.ReadLine();

                        Console.Write("License: ");
                        string lic = Console.ReadLine();

                        customers.Add(new Customer(cid, name, contact, lic));
                        Console.WriteLine("Customer Registered!");
                        break;

                    case 3:
                        Console.Write("Enter Reg No: ");
                        string r = Console.ReadLine();

                        Console.Write("Days: ");
                        int days = int.Parse(Console.ReadLine());

                        foreach (var v in vehicles)
                        {
                            if (v.GetRegistrationNumber() == r)
                            {
                                Console.WriteLine("Total Cost: $" + v.CalculateRentalCost(days));
                            }
                        }
                        break;

                    case 4:
                        foreach (var c in customers)
                        {
                            c.DisplayDetails();
                            Console.WriteLine();
                        }
                        break;
                }

            } while (choice != 5);
        }
    }
    }

