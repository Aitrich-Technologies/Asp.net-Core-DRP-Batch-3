using System;
using System.Collections.Generic;
using System.Text;

namespace oopsamlpe4
{
    internal class payment
    {
        private double amount;

        public void SetAmount(double amt)
        {
            if (amt > 0)
            {
                amount = amt;
            }
            else
            {
                Console.WriteLine("Invalid amount! Must be greater than 0.");
            }
        }

        public double GetAmount()
        {
            return amount;
        }

        public void MakePayment()
        {
            if (amount > 0)
            {
                Console.WriteLine("Payment of " + amount + " is successful.");
            }
            else
            {
                Console.WriteLine("Payment failed. Amount not set properly.");
            }
        }
    }
}
    

