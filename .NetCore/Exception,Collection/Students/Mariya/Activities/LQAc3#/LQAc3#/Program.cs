using System;
using System.Collections.Generic;
using System.Linq;
namespace LQAc3_
{
    class Employee
    {
        public int Id;
        public string Name;
        public string Department;
    }

    class Program
    {
        static List<Employee> employees = new List<Employee>();

        static void Main()
        {
            int choice;

            do
            {
                Console.WriteLine("\n1. Add Employee");
                Console.WriteLine("2. Show Employees");
                Console.WriteLine("3. Filter by Department");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;

                    case 2:
                        DisplayEmployees();
                        break;

                    case 3:
                        FilterDepartment();
                        break;

                    case 4:
                        Console.WriteLine("Program Ended");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 4);
        }

        static void AddEmployee()
        {
            Employee emp = new Employee();

            Console.Write("Enter ID: ");
            emp.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            emp.Name = Console.ReadLine();

            Console.Write("Enter Department: ");
            emp.Department = Console.ReadLine();

            employees.Add(emp);

            Console.WriteLine("Employee Added");
        }

        static void DisplayEmployees()
        {
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}");
                Console.WriteLine($"Name: {emp.Name}");
                Console.WriteLine($"Department: {emp.Department}");
                Console.WriteLine();
            }
        }

        static void FilterDepartment()
        {
            Console.Write("Enter Department: ");
            string dept = Console.ReadLine();

            var result = employees.Where(e => e.Department == dept);

            foreach (Employee emp in result)
            {
                Console.WriteLine($"ID: {emp.Id}");
                Console.WriteLine($"Name: {emp.Name}");
                Console.WriteLine($"Department: {emp.Department}");
                Console.WriteLine();
            }
        }
    }
}
