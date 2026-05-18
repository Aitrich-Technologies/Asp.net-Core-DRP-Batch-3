using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_Handling
{
    internal class AgeException : Exception
    {
        public AgeException(string message) :base(message) { }
    }
}
