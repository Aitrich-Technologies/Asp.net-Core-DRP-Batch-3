using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2.Exceptions
{
    public class InvalidPhoneException : Exception
    {
        public InvalidPhoneException(string message) : base(message)
        {
        }
    }
}


