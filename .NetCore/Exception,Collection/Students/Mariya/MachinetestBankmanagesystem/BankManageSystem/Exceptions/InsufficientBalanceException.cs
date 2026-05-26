using System;
using System.Collections.Generic;
using System.Text;

namespace BankManageSystem.Exceptions
{
    internal class InsufficientBalanceException:Exception
    {
        public InsufficientBalanceException(
             string message)
             : base(message) { }
        
   
    }
}
