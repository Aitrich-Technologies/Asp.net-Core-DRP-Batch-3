using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OOPs
{
    internal class Employee:Person
    {
        public string EmployeeId { get; set; }
        public string Position { get; set; }

        public Employee(string id, string name, string contact, string position)
        {
            EmployeeId = id;
            Name = name;
            ContactNumber = contact;
            Position = position;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Contact: " + ContactNumber);
            Console.WriteLine("Position: " + Position);
        }
    }

}
