using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using Excercise2.Enums;
using Excercise2.Exceptions;
using Excercise2.Interface;
using Excercise2.Models;

namespace Excercise2.Repository
{
  public class UserRepository:IUserRepository
    {
        private List<User> users = new List<User>()
        {
            new User("Agent","One","agent@gmail.com",9876543210,"1234",Roles.Agent)
        };

        public User Login(string email, string password)
        {
            var user = users
                .FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user == null)
                throw new InvalidCredentialsException("Invalid email or password!");

            return user;
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public List<User> GetConsultants()
        {
            return users
                .Where(u => u.Role == Roles.Consultant)
                .ToList();
        }
    }
}