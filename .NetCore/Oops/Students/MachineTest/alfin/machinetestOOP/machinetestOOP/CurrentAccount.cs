using System;
using System.Collections.Generic;
using System.Text;

namespace machinetestOOP
{
    internal class CurrentAccount:Account
    {
        
        
        public override void CalculateInterest()
        {
            Console.WriteLine("No interest");
        }
        public void ApplyMaintenanceFee()
        {
            double fee = 500;
            Balance -= fee;
            Console.WriteLine("maintenance fee:" + fee);
            Console.WriteLine("balance:" + Balance);
        }
    }
}
