using ExerciseException1.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseException1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long Phone { get; set; }
        public string Password { get; set; }
        public Roles Roles { get; set; }
        public User() { }
        public User(string fname, string lname, string email, long phone, string password, Roles role)
        { 
          
            FirstName = fname;
            LastName = lname;
            Email = email;
            Phone = phone;
            Password = password;
            Roles = role;

        }
           
    }
}
