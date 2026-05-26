using Exercise.Interface;
using Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Repository
{
    public class UserRepository :IUserRepository
    {
        private List<User> users = new List<User>();

        private static User LoggedUser;

        public void Register(User user)
        {
            users.Add(user);
        }

        public User Login(string email, string password)
        {
            LoggedUser =
                users.FirstOrDefault
                (
                    u => u.Email == email
                    &&
                    u.Password == password
                );

            return LoggedUser;
        }

        public User GetLoggedUser()
        {
            return LoggedUser;
        }
    }
}

