using System;
using System.Collections.Generic;
using System.Text;

namespace activityoverloadOOP
{
    internal class payment
    {
        public void pay(double amount)
        {
            Console.WriteLine(amount);
        }
        public  void pay(double amount,string method)
            {
            Console.WriteLine(amount+method);    
        }
    }
}
