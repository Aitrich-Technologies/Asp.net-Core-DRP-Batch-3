using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin_Destination.Enums;

namespace Admin_Destination.Models
{
    public  class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double Phone { get; set; }
        public Roles Role { get; set; }

        public User() { }

        public User(int id, string name, string email, string password, double phone, Roles role)
        {
            Id = id;
            FirstName = name;
            Email = email;
            Password = password;
            Phone = phone;
            Role = role;
        }
    }

}

