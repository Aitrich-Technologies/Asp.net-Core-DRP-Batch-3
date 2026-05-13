using System;
using System.Collections.Generic;
using System.Text;

namespace Override_
{
    internal class FullTimeEmployee:Employee
    {
        public double MonthlySalary { get; set; }

        public FullTimeEmployee(double salary)
        {
            MonthlySalary = salary;
        }

        public override double CalculateSalary()
        {
            return MonthlySalary;
        }
    }
}
