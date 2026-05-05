using System;
using System.Collections.Generic;
using System.Text;

namespace Zag_act3
{
    internal class Car:Vehicle
    {
        public int NumberOfSeats { get; set; }

        public Car(string make, string model, int year, string regNo, int seats)
            : base(make, model, year, regNo)
        {
            NumberOfSeats = seats;
        }

        public override double CalculateRentalCost(int days)
        {
            return days * 50; // $50 per day
        }

    }
}
