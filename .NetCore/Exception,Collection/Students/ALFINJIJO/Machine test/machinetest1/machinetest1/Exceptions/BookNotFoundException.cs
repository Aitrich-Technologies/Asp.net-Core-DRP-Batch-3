using System;
using System.Collections.Generic;
using System.Text;

namespace machinetest1.Exceptions
{
    public class BookNotFoundException : Exception
    {
        public BookNotFoundException(string message) : base(message)
        {
        }
    }
}
