using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs
{
    internal class Vehicle
    {
        private string RegistrationNumber;
        public string Model;
        public int Year;
        public string Make;


        public Vehicle(string make, string model, int year, string reg )
        {
            RegistrationNumber = reg;
            Model = model;
            Year = year;
            Make = make;
        }

        public string GetRegistrationNumber()
        {
            return RegistrationNumber;
        }
        public virtual double CalculateRentalCost(int days)
        {
            return 0;
        }
    }
}
