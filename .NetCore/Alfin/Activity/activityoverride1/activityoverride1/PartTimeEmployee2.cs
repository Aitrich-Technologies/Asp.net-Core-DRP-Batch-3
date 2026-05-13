using System;
using System.Collections.Generic;
using System.Text;

namespace activityoverride1
{
    internal class PartTimeEmployee2:employee02
    {
        public override void CalculateSalary()
        {
            int hours = 5;
            int rate = 200;
            int salary = hours * rate;
            Console.WriteLine("Part Time Salary: " + salary);
        }

    }
}
