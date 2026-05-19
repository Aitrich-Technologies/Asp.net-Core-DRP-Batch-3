using System;
using System.Collections.Generic;
using System.Text;

namespace machinetestOOP
{
    internal class SavingsAccount:Account
    {
        private const double InterestRate = 0.05;
       
         
        public override void CalculateInterest()
        {
            double interest = Balance * InterestRate;
            Balance += interest;

            Console.WriteLine("Interest Added: " + interest);
            Console.WriteLine("Updated Balance after Interest: " + Balance);
        }
    }
}
