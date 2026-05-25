using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_activities
{
    internal class Program
    {
        class TourPackage
        {
            public int Id;
            public string Name;
            public string Destination;
            public double Price;
        }

        class Employee
        {
            public int Id;
            public string Name;
            public int Age;
            public string Department;
        }
        static void Main(string[] args)
        {
            List<TourPackage> tours = new List<TourPackage>();

            int choice = 0;

            while (choice != 7)
            {
                Console.WriteLine();
                Console.WriteLine("1.Add Tour");
                Console.WriteLine("2.Display Tours");
                Console.WriteLine("3.Average Price");
                Console.WriteLine("4.Rank Tours");
                Console.WriteLine("5.Remove Tour");
                Console.WriteLine("6.Find Tour");
                Console.WriteLine("7.Exit");

                Console.Write("Enter Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        TourPackage t = new TourPackage();

                        Console.Write("Enter Id: ");
                        t.Id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Name: ");
                        t.Name = Console.ReadLine();

                        Console.Write("Enter Destination: ");
                        t.Destination = Console.ReadLine();

                        Console.Write("Enter Price: ");
                        t.Price = Convert.ToDouble(Console.ReadLine());

                        tours.Add(t);

                        Console.WriteLine("Tour Added");
                        break;

                    case 2:

                        Console.WriteLine("Tour List");

                        foreach (TourPackage tour in tours)
                        {
                            Console.WriteLine(
                                tour.Id + " " +
                                tour.Name + " " +
                                tour.Destination + " " +
                                tour.Price);
                        }

                        break;

                    case 3:

                        double avg = tours.Average(x => x.Price);

                        Console.WriteLine("Average Price = " + avg);

                        break;
                        
                    case 4:

                        var ranked = tours.OrderByDescending(x => x.Price);

                        Console.WriteLine("Ranked Tours");

                        foreach (TourPackage tour in ranked)
                        {
                            Console.WriteLine(
                                tour.Name + " - " + tour.Price);
                        }

                        break;

                    case 5:

                        Console.Write("Enter Id to Remove: ");
                        int rid = Convert.ToInt32(Console.ReadLine());

                        TourPackage removeTour =
                            tours.Find(x => x.Id == rid);

                        if (removeTour != null)
                        {
                            tours.Remove(removeTour);
                            Console.WriteLine("Removed");
                        }
                        else
                        {
                            Console.WriteLine("Not Found");
                        }

                        break;

                    case 6:

                        Console.Write("Enter Tour Name: ");
                        string search = Console.ReadLine();

                        TourPackage found =
                            tours.Find(x => x.Name == search);

                        if (found != null)
                        {
                            Console.WriteLine(
                                found.Id + " " +
                                found.Name + " " +
                                found.Destination + " " +
                                found.Price);
                        }
                        else
                        {
                            Console.WriteLine("Not Found");
                        }

                        break;

                    case 7:

                        Console.WriteLine("Program Ended");
                        break;

                    default:

                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

            //List<Employee> employees = new List<Employee>();

            //// Add employees
            //employees.Add(new Employee { Id = 1, Name = "Anu", Age = 25, Department = "HR" });
            //employees.Add(new Employee { Id = 2, Name = "Rahul", Age = 30, Department = "IT" });
            //employees.Add(new Employee { Id = 3, Name = "Meera", Age = 28, Department = "Finance" });
            //employees.Add(new Employee { Id = 4, Name = "Arjun", Age = 35, Department = "IT" });

            //// Display all employees
            //Console.WriteLine("All Employees");
            //Console.WriteLine();

            //foreach (Employee emp in employees)
            //{
            //    Console.WriteLine(
            //        "Id: " + emp.Id +
            //        " Name: " + emp.Name +
            //        " Age: " + emp.Age +
            //        " Department: " + emp.Department);
            //}

            //Console.WriteLine();

            //// Filter by department
            //Console.Write("Enter Department: ");
            //string dept = Console.ReadLine();


            //IEnumerable<Employee> filteredEmployees =
            //    employees.Where(e => e.Department == dept);

            //Console.WriteLine();
            //Console.WriteLine("Filtered Employees");

            //foreach (Employee emp in filteredEmployees)
            //{
            //    Console.WriteLine(
            //        "Id: " + emp.Id +
            //        " Name: " + emp.Name +
            //        " Age: " + emp.Age +
            //        " Department: " + emp.Department);
            //}

            //Console.ReadLine();
        }
    }
    }

