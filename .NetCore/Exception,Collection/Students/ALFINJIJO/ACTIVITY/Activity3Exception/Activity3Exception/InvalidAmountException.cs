using System;
using System.Collections.Generic;
using System.Text;

namespace Activity3Exception
{
    internal class InvalidAmountException : Exception
    {
        public InvalidAmountException(string message) : base(message) { }
    }
}
