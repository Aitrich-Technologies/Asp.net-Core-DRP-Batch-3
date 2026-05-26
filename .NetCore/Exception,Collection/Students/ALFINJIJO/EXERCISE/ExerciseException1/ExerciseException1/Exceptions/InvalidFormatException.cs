using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseException1.Exceptions
{
    public class InvalidFormatException : Exception
    {
        public InvalidFormatException(string message)
         : base(message)
        {
        }
    }
}
