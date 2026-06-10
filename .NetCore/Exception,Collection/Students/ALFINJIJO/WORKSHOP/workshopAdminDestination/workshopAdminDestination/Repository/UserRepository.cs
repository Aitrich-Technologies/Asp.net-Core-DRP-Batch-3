using System;
using System.Collections.Generic;
using System.Text;
using workshopAdminDestination.Enums;
using workshopAdminDestination.Interface;
using workshopAdminDestination.Models;

namespace workshopAdminDestination.Repository
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
                loggedUser = users.FirstOrDefault(u => u.Email == email && u.Password == password);
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
