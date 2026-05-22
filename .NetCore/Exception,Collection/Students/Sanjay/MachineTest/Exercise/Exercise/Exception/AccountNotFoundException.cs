using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class AccountNotFoundException : Exception
    {
        public AccountNotFoundException(string message) : base(message)
        {

        }
    }
}
