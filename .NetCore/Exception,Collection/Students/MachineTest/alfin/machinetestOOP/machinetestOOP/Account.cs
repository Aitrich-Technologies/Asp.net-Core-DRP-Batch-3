using System;
using System.Collections.Generic;
using System.Text;

namespace machinetestOOP
{
    internal abstract class Account
    {
        public string Accountholder;
        public double Balance;

       
        public abstract  void CalculateInterest();

        public  void DisplayDetails()
        {
            Console.WriteLine("Account Holder: " + Accountholder);
            Console.WriteLine("Balance:  " + Balance);

        }


    }
}
