using ExerciseOop1.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseOop1.Model
{
    public class AuthUser
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRoles Role { get; set; }
    }

}
