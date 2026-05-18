using System;
using System.Collections.Generic;
using System.Text;

namespace activityabstractoop
{
    internal abstract class payment2
    {
        public double amount {  get; set; }
        public string paymentdate {  get; set; }
        public string transactionid {  get; set; }
        public abstract void MakePayment();
    }
}
