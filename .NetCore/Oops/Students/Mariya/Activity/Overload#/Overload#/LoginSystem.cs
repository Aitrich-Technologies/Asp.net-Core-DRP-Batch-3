using System;
using System.Collections.Generic;
using System.Text;

namespace Overload_
{
    internal class LoginSystem
    {
        public void Login(string username)
        {
            Console.WriteLine($"Logged in as {username} (guest mode)");
        }

        // Method 2 (Overloaded)
        public void Login(string username, string password)
        {
            Console.WriteLine($"Logged in as {username} with password authentication");
        }
    }
}
