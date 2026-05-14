using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise1.Exceptions;
using Excercise1.Interface;
using Excercise1.Models;

namespace Excercise1.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<User> users = new List<User>();

        public void Register(User user)
        {
            var existing = users.FirstOrDefault(u => u.Email == user.Email);

            if (existing != null)
                throw new UserAlreadyExistsException("User already exists!");

            user.Id = users.Count + 1;
            users.Add(user);
        }

        public User Login(string email, string password)
        {
            var user = users.FirstOrDefault(u =>
                        u.Email == email && u.Password == password);

            if (user == null)
                throw new InvalidCredentialsException("Invalid Email or Password");

            return user;
        }

        public List<User> GetAll()
        {
            return users;
        }
    }
}

