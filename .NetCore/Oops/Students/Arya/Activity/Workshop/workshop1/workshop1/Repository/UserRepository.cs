using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using workshop1.Models;
using workshop1.Interface;

namespace workshop1.Repository
{
    public class UserRepository: IUserRepository
    {
        private AuthUser[] users = new AuthUser[10];
        private int count = 0;

        public UserRepository()
        {
            // Default Agency
            users[count++] = new AuthUser
            {
                UserId = 1,
                Username = "admin",
                Password = "admin",
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
                if (users[i].Username == username && users[i].Password == password)
                    return users[i];
            }
            return null;
        }
    }
}
