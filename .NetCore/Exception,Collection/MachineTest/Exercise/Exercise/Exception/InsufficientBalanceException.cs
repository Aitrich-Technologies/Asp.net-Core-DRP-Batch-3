using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {

        }
    }
}
