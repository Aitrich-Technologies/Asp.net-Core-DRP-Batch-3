using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction_3
{
    internal class employee : person
    {
        public int Employeeid;
        public string position;

        public override void DisplayDetails()
        {
            {
                Console.WriteLine("ID" + Employeeid);
                Console.WriteLine("position" + position);
            }
        }
        



        


    }
}
