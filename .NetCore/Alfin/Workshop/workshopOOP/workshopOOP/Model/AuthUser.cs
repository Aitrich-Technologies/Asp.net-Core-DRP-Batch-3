using System;
using System.Collections.Generic;
using System.Text;
using workshopOOP.Enum;

namespace workshopOOP.Model
{
    public class AuthUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserRoles Roles { get; set; }
    }
}
