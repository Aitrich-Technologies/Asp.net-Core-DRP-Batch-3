using System;
using System.Collections.Generic;
using System.Text;

namespace activityoverloadOOP
{
    internal class booking
    {
        public  void Book(int seat)
        {
            Console.WriteLine( seat );
            
        }

        public void Book(int seats, string name)
        {
            Console.WriteLine( seats +  name);
        }

    }
}
