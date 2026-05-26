using System;
using System.Collections.Generic;
using System.Text;

namespace Zag_act3
{
    internal class Employee:Person
    {
        public string EmployeeId { get; set; }
        public string Position { get; set; }

        public Employee(string id, string name, string contact, string position)
            : base(name, contact)
        {
            EmployeeId = id;
            Position = position;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Contact Number: {ContactNumber}");
            Console.WriteLine($"Position: {Position}");
        }
    }
}
