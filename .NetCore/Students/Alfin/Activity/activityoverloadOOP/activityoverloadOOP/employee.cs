using System;
using System.Collections.Generic;
using System.Text;

namespace activityoverloadOOP
{
    internal class employee
    {
        public int CalculateSalary(int basic)
        {
            return basic;
        }

    
        public int CalculateSalary(int basic, int bonus)
        {
            return basic + bonus;
        }

        
        public int CalculateSalary(int basic, int bonus, int tax)
        {
            return basic + bonus - tax;
        }
    }
}
