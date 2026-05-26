using System;
using System.Collections.Generic;
using System.Text;

namespace BankManageSystem.Exceptions
{
    public class AccountNotFoundException:Exception
    {
        public AccountNotFoundException(string message)
            : base(message) { }
        
       
    }
}
