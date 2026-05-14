using System;
using System.Collections.Generic;
using System.Text;

namespace activityoverloadOOP
{
    internal class loginsystem
    {
        public string Login(string username)
        {
            return username;
        }

        
        public string Login(string username, string password)
        {
            return username+password;
        }
    }
}
