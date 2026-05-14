using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_3
{
    internal  class customer:person
    {
        public int CustomerID;
        public int phonenumber;

        public override void DisplayDetails()
        {
            Console.WriteLine("customer id" +  CustomerID);
            Console.WriteLine("Phonenumber" + phonenumber);
        }

    }
}
