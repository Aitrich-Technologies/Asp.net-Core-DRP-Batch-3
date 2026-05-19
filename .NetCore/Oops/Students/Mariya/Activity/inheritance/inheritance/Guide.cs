using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    internal class Guide:Employee
    {
        public string langauages;
        public string Expertise;

        public void showguidedetails()
        {
            Console.WriteLine("Langauages:" + langauages);
            Console.WriteLine("Expertise:" + Expertise);
        }

    }
}
