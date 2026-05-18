using System;
using System.Collections.Generic;
using System.Text;

namespace activityabstractoop
{
    internal class upipayment2:payment2
    {
        public string UPIId {  get; set; }

        public override void MakePayment()
        {
            Console.WriteLine("made upi payment");
            Console.WriteLine("amount:" + amount);
             Console.WriteLine("date:" + paymentdate);
            Console.WriteLine("transaction id:" + transactionid);
            Console.WriteLine("UPI Id:" + UPIId);
        }
    }
}
