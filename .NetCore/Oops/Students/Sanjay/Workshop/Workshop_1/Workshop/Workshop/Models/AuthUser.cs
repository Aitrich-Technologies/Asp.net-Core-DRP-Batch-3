using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Enum;

namespace Workshop.Models
{
    internal class AuthUser
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRoles Role { get; set; }

    }
}
