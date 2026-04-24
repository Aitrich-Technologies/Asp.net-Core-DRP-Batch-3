using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p;
            p = new customer
            {
             id = 1,
             licencenumber = 1,
             

            };
            p.details();

            p = new Employee
            {
                Id = 1,
                position = "developer"

            };
            p.details();

        }
           
    }
}
