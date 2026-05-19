using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverloading_activity
{
    internal class Login
    {
        public void login(string username)
        {
            Console.WriteLine("Login with username: " + username);
        }

        public void login(string username, string password)
        {
            Console.WriteLine("Login with username: " + username + " and password: " + password);
        }
    }
}
