using System;
using System.Collections.Generic;
using System.Text;

namespace activityoverride1
{
    internal class FullTimeEmployee2:employee02
    {
        public override void CalculateSalary()
        {
            int salary = 30000;
            Console.WriteLine("Full Time Salary: " + salary);
        }
    }
}
