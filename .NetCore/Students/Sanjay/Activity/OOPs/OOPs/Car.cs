using System;
using System.Collections.Generic;
using System.Text;

namespace OOPs
{
    internal class Car:Vehicle
    {
        public int NumberOfSeats;

        public Car(string make,string model, int year, string reg, int seats) : base(make, model, year, reg)
        {
            NumberOfSeats = seats;
        }

        public override double CalculateRentalCost(int days)
        {
            return days * 50;
        }
    }
}
