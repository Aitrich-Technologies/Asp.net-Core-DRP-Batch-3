using System;
using System.Collections.Generic;
using System.Text;
using WRK_.Enum;

namespace WRK_.Models
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

