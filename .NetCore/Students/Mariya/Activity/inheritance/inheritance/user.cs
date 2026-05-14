using System;
using System.Collections.Generic;
using System.Text;

namespace inheritance
{
    internal class user
    {
        public int userid;
        public string name;


        public void login()
        {
            Console.WriteLine(name + "logged.in");
        }
    }
}
