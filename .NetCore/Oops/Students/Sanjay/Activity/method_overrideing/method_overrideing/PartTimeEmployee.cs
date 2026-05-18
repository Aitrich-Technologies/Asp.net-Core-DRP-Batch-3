using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    class PartTimeEmployee : Employee
    {
        public double hoursWorked;
        public double hourlyRate;

        public PartTimeEmployee(double hours, double rate)
        {
            hoursWorked = hours;
            hourlyRate = rate;
        }

        public override void CalculateSalary()
        {
            double salary = hoursWorked * hourlyRate;
            Console.WriteLine("Part-Time Salary: " + salary);
        }
    }
}
