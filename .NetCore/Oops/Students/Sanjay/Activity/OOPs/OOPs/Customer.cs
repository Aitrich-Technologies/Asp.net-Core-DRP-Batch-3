using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OOPs
{
    internal class Customer:Person
    {
        public string CustomerId { get; set; }

        private string drivingLicenseNumber;

        public string GetLicense()
        {
            return drivingLicenseNumber;
        }

        public Customer(string id, string name, string contact, string license)
        {
            CustomerId = id;
            Name = name;
            ContactNumber = contact;
            drivingLicenseNumber = license;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Customer Details:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Contact: " + ContactNumber);
            Console.WriteLine("Driving License: " + drivingLicenseNumber);
        }
    }
}
