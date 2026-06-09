using System;
using System.Collections.Generic;
using System.Text;

namespace machinetest1.Exceptions
{
    public class OutOfStockException : Exception
    {
        public OutOfStockException(string message) : base(message)
        {
        }
    }
}
