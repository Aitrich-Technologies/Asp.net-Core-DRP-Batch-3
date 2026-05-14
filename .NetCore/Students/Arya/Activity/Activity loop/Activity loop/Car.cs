using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_loop
{
    internal class Car:Vehicle
    {
        public int NumberOfSeats;

        public Car(string make, string model, int year, string regNo, int seats)
            : base(make, model, year, regNo)
        {
            NumberOfSeats = seats;
        }

        public override double CalculateRentalCost(int days)
        {
            return days * 50;
        }
    }
}
