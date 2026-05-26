using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machinetest.Exceptions
{
    public  class OutofStockException:Exception
    {
        public OutofStockException(string message) 
            :base (message)
        
        {
        }
    }
}
