using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WEH1.Enums;

namespace WEH1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }

        public User() { }

        public User(int id, string name, string email, string password, Roles role)
        {
            Id = id;
            FirstName = name;
            Email = email;
            Password = password;
            Role = role;
        }
    }
}
