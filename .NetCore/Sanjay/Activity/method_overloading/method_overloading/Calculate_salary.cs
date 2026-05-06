using System;
using System.Collections.Generic;
using System.Text;

namespace method_overloading
{
    internal class Calculate_salary
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
            return basic + bonus + tax;
        }
    }
}
