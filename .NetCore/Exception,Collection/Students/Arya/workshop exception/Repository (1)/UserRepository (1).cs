using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin_Destination.Enums;
using Admin_Destination.Interface;
using Admin_Destination.Models;

namespace Admin_Destination.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<User> users = new List<User>
        {
            new User(1,"AdminOne","admin1@tour.com","123",Roles.Admin),
            new User(2,"AdminTwo","admin2@tour.com","123",Roles.Admin)
        };

        private static User loggedUser;

        public User Login(string email, string password)
        {
            loggedUser = users.FirstOrDefault(u => u.Email == email && u.Password == password );
            return loggedUser;
        }

        public List<User> GetAllAdmins()
        {
            return users;
        }

        public User GetLoggedUser()
        {
            return loggedUser;
        }
    }
}



