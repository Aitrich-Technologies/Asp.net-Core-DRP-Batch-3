using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    class FullTimeEmployee : Employee
    {
        public double monthlySalary;

        public FullTimeEmployee(double salary)
        {
            monthlySalary = salary;
        }

        public override void CalculateSalary()
        {
            Console.WriteLine("Full-Time Salary: " + monthlySalary);
        }
    }
}
