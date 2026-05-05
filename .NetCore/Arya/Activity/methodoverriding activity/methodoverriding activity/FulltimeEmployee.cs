using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding_activity
{
    internal class FulltimeEmployee:EmployeeSalary
    {
        public override void calculatesalary()
        {
            Console.WriteLine("Full Time Salary: 25000");
        }
    }
}
