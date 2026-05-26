using System;
using System.Collections.Generic;
using System.Text;

namespace workshopAdminDestination.Exceptions
{

    public class InvalidFormatException : Exception
    {
        public InvalidFormatException(string message) : base(message) { }
    }

}
