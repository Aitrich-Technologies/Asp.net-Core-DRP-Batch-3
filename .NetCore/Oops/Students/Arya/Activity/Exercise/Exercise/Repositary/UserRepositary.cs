using Exercise.Interface;
using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Repositary
{
    public class UserRepositary : IUserRepositary
    {
        private AuthUser[] users = new AuthUser[10];
        private int count = 0;

        public UserRepositary()
        {
            // Default Agency
            users[count++] = new AuthUser
            {
                UserId = 1,
                Username = "admin",
                Password = "admin",
                Role = Enum.UserRoles.Admin
            };
        }
        public void Register(AuthUser user)
        {
            users[count++] = user;
        }

        public AuthUser Login(string username, string password)
        {
            for (int i = 0; i < count; i++)
            {
                if (users[i].Username == username && users[i].Password == password)
                    return users[i];
            }
            return null;
        }
    }
}
