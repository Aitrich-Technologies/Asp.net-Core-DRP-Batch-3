using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise3.Enums;
using Excercise3.Exceptions;
using Excercise3.Interface;
using Excercise3.Models;

namespace Excercise3.Repository
{
  public class UserRepository:IUserRepository
    {
        private List<User> users = new List<User>();
        private static User loggedUser;
        public UserRepository()
        {
            // Hardcoded Agent
            users.Add(new User("Admin", "Agent","agent@gmail.com",9999999999,"123", Roles.Agent) { Id = 1 });
            users.Add(new User("Admin", "Agent","agent1@gmail.com",8888888888,"1234", Roles.Agent){ Id = 2 });
            users.Add(new User("Admin", "Agent", "agent01@gmail.com",7777777777, "12345", Roles.Agent) { Id = 3});
        }
        public  List<User> getAllAgent()
        {
           return users.Where(e => e.Role == Roles.Agent).ToList();
        }

        public void Register(User user)
        {
            if (users.Any(u => u.Email == user.Email))
                throw new UserAlreadyExistsException();

            user.Id = users.Count + 1;
            users.Add(user);
        }

        public User Login(string email, string password)
        {
            var user = users
                .FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user == null)
                throw new InvalidLoginException();
            loggedUser = user;

            return user;
        }

        public User getLoggedUser()
        {
            return loggedUser;
        }
    }
}

