using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace inheritance
{
    internal class Touroperator:user
    {
        public void createtourpackage()
        {
            Console.WriteLine(name + "created tour package");
        }
    }
}
