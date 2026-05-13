using System;
using System.Collections.Generic;
using System.Text;

namespace Zag_act3
{
    internal class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        private string registrationNumber; // Encapsulated

        public string GetRegistrationNumber()
        {
            return registrationNumber;
        }

        public Vehicle(string make, string model, int year, string regNo)
        {
            Make = make;
            Model = model;
            Year = year;
            registrationNumber = regNo;
        }

        // 2. POLYMORPHISM
        public virtual double CalculateRentalCost(int days)
        {
            return 0;
        }
    }
}
