using System;
using System.Collections.Generic;
using System.Text;

namespace method_overloading
{
    internal class Login_system
    {
        public string Login(string username)
        {
            return username;
        }
        public string Login(string username, string password)
        {
            return username + password;
        }
    }
}
