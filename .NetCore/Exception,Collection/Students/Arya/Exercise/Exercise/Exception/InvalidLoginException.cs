using System;

namespace Exercise.Exceptions
{
    public class InvalidLoginException : Exception
    {
        public InvalidLoginException(string message)
            : base(message)
        {

        }
    }
}