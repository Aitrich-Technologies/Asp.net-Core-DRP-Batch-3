using Exercise.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise.Models
{
    public class AuthUser
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRoles Role { get; set; }



        public void Display()
        {
            Console.WriteLine($"ID: {UserId} | {Role}: {Username}");
        }
    }


}
