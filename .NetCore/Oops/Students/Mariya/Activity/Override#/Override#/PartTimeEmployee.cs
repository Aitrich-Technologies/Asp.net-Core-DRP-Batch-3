using System;
using System.Collections.Generic;
using System.Text;

namespace Override_
{
    internal class PartTimeEmployee:Employee
    {

        public int HoursWorked { get; set; }
        public double HourlyRate { get; set; }

        public PartTimeEmployee(int hours, double rate)
        {
            HoursWorked = hours;
            HourlyRate = rate;
        }

        public override double CalculateSalary()
        {
            return HoursWorked * HourlyRate;
        }
    }
}
