using System;
using System.Collections.Generic;
using System.Text;

namespace Overload_
{
    internal class EmployeeSalary
    {
        public void CalculateSalary(int basic)
        {
            Console.WriteLine($"Salary: {basic}");
        }

        // Method 2 (Overloaded)
        public void CalculateSalary(int basic, int bonus)
        {
            int total = basic + bonus;
            Console.WriteLine($"Salary with Bonus: {total}");
        }

        // Method 3 (Overloaded)
        public void CalculateSalary(int basic, int bonus, int tax)
        {
            int total = basic + bonus - tax;
            Console.WriteLine($"Salary after Bonus and Tax: {total}");
        }
    }
}
