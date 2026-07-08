using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding_activity
{
    internal class EmployeeSalary
    {
        public virtual void calculatesalary()
        {
            Console.WriteLine("calculate salary");
        }
    }
}
