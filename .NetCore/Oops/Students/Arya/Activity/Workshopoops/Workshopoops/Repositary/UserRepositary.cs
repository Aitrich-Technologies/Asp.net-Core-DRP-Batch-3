using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshopoops.Interface;
using Workshopoops.Models;

namespace Workshopoops.Repositary
{
    public class UserRepository : IUserRepositary
    {
        private AuthUser[] users = new AuthUser[10];
        private int count = 0;

        public UserRepository()
        {
            
            users[count++] = new AuthUser
            {
                userid = 1,
                username = "admin",
                password = "admin",
                Role = Enum.UserRoles.Agency
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
                if (users[i].username == username && users[i].password == password)
                    return users[i];
            }
            return null;
        }
    }
}
