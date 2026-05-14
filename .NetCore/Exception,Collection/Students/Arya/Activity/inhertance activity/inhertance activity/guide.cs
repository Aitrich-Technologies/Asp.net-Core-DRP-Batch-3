using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhertance_activity
{
    internal class guide:Employee
    {
        public string langauages;
        public string Expertise;

        public void showguidedetails()
        {
            Console.WriteLine("Langauages:"+ langauages);   
            Console.WriteLine("Expertise:" + Expertise);
        }


    }
}
