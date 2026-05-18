using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverloading_activity
{
    internal class Employee
    {
        public void CalculateSalary(int basic)
        {
            Console.WriteLine("Salary: " + basic);
        }

        public void CalculateSalary(int basic, int bonus)
        {
            Console.WriteLine("Salary: " + (basic + bonus));
        }

        public void CalculateSalary(int basic, int bonus, int tax)
        {
            Console.WriteLine("Salary after tax: " + (basic + bonus - tax));
        }
    }
}
