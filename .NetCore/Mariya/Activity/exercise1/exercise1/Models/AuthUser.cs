using System;
using System.Collections.Generic;
using System.Text;
using exercise1.Enum;

namespace exercise1.Models
{
    //internal class AuthUser
    //{
        public class AuthUser
        {
            public int UserId { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public UserRoles Roles { get; set; }
        }
    }

