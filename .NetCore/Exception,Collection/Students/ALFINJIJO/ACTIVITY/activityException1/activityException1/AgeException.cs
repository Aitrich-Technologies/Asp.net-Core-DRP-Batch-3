using System;
using System.Collections.Generic;
using System.Text;

namespace activityException1
{
    internal class AgeException : Exception
    {
        public AgeException(string message):base(message) { }
    }
}
