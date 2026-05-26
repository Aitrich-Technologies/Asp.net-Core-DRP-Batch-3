using ExerciseException1.Enum;
using ExerciseException1.Exceptions;
using ExerciseException1.Interface;
using ExerciseException1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseException1.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<User> users = new List<User>()
        {
            new User("Agent","One","sanjay@gmail.com",7899876545,"222",Roles.Agent)
        };

        public User Login(string email, string password)
        {
            var user = users.FirstOrDefault(x => x.Email == email && x.Password == password);

            if (user == null)
            {
                throw new InvalidFormatException("Invalid email or password!");
            }
            return user;
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public List<User> GetConsultants()
        {
            return users
                .Where(x => x.Roles == Roles.Consultant) .ToList();
        }
    }
}
