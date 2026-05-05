using System;
using System.Collections.Generic;
using System.Text;

namespace method_overrideing
{
    internal class Employee
    {
        public virtual void CalculateSalary()
        {
            Console.WriteLine("Calculating Salary...");
        }
    }
}
