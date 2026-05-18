using System;
using System.Collections.Generic;
using System.Text;

namespace activityabstractoop
{
    internal class cardpayment2:payment2
    {
        public string cardnumber {  get; set; }
        public string cardholdername {  get; set; }
        public override void MakePayment()
        {
            Console.WriteLine("made card payment");
            Console.WriteLine("amount:" + amount);
            Console.WriteLine("date:" + paymentdate);
            Console.WriteLine("transaction id:" + transactionid);
            Console.WriteLine("card holder:" + cardholdername);

        }
    }
}
