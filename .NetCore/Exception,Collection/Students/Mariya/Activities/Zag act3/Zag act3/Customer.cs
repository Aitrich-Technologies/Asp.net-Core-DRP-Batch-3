using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Zag_act3
{
    internal class Customer:Person
    {
        public string CustomerId { get; set; }

        private string drivingLicenseNumber; // Encapsulated

        public string GetDrivingLicense()
        {
            return drivingLicenseNumber;
        }

        public Customer(string id, string name, string contact, string license)
            : base(name, contact)
        {
            CustomerId = id;
            drivingLicenseNumber = license;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Customer Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Contact Number: {ContactNumber}");
            Console.WriteLine($"Driving License: {GetDrivingLicense()}");
        }
    }
}
