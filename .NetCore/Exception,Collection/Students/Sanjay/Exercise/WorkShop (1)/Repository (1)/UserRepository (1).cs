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
        private User[] users = new User[10];
        private int count = 0;
        public UserRepository()
        {
            users[count++] = new User
            {
                Id = 1,
                FirstName = "Admin",
                Password = "admin",
                Email = "admin@gmail.com",
                Role = Enums.Roles.Admin,

            };
            users[count++] = new User
            {
                Id = 2,
                FirstName = "Admin2",
                Password = "admin",
                Email = "admin2@gmail.com",
                Role = Enums.Roles.Admin,

            };
        }

        private static User loggedUser;

        public User Login(string email, string password)
        {
            loggedUser = users.FirstOrDefault(u => u.Email == email && u.Password == password );
            return loggedUser;
        }
        
        public void AddCustomer(User user)
        {
            users[count++] = user;
        }

        public User[] GetAllAdmins()
        {

            return users;
        }

        public User GetLoggedUser()
        {
            return loggedUser;
        }
    }
}



