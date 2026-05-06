using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverloading_activity
{
    internal class Payment
    {
        public void pay(double amount)
        {
            Console.WriteLine("paid:" + amount);
        }
        public void Pay(double amount, string method)
        {
            Console.WriteLine("paid:" + amount + "Using" + method);
        }
       
    }
}
