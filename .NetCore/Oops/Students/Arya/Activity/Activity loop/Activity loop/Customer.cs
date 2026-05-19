using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_loop
{
    internal class Customer:Person
    {
        
    public string CustomerId;
        private string license;

        public Customer(string id, string name, string contact, string license)
        {
            CustomerId = id;
            Name = name;
            Contact = contact;
            this.license = license;
        }

        public string GetLicense()
        {
            return license;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("Customer ID: " + CustomerId);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Contact: " + Contact);
            Console.WriteLine("License: " + license);
        }
    }
}

