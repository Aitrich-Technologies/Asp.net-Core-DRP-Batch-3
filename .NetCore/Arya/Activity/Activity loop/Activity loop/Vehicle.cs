using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_loop
{
    internal class Vehicle
    {
        public string Make;
        public string Model;
        public int Year;

        private string RegistrationNumber;

        public Vehicle(string make, string model, int year, string regNo)
        {
            Make = make;
            Model = model;
            Year = year;
            RegistrationNumber = regNo;

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
