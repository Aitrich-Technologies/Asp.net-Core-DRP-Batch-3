using System;
using System.Collections.Generic;
using System.Text;

namespace ENS
{
    internal class Payment
    {
        private double amount;

        // Setter with validation
        public void SetAmount(double value)
        {
            if (value > 0)
            {
                amount = value;
            }
            else
            {
                Console.WriteLine("Invalid amount! Amount must be greater than 0.");
            }
        }

        // Getter (optional but good practice)
        public double GetAmount()
        {
            return amount;
        }

        // Method to make payment
        public void MakePayment()
        {
            if (amount > 0)
            {
                Console.WriteLine($"Payment of ${amount} successful.");
            }
            else
            {
                Console.WriteLine("Payment failed. Please set a valid amount first.");
            }
        }
    }
}
