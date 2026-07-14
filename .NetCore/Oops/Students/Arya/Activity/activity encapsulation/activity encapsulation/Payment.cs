using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_encapsulation
{
    internal class Payment
    {
        private double amount;
        public void setamount(double amount)
        {
            if (amount > 0)
            {
                this.amount = amount;
            }
            else
            {
                this.amount = 0;

            }
        }
        public string getamount()
        {
            return "Payment Amount: " + amount;
        }
    }
}
