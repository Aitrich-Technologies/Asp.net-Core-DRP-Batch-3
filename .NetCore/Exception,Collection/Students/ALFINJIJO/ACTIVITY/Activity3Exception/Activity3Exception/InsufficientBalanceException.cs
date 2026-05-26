using System;
using System.Collections.Generic;
using System.Text;

namespace Activity3Exception
{
    internal class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }
}
