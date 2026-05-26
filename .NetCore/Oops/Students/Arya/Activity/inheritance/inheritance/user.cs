using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class user
    {
        public int id;
        public string email;
        public string password;

        public bool Login()
        {
            Console.WriteLine("email successful");
            return true;
        }
    }
}
