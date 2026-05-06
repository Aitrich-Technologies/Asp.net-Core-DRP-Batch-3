using EX_.Enum;
using EX_.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace EX_.Models;

public class AuthUser
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public UserRoles Role { get; set; }
}

