using ExerciseOop1.Interface;
using ExerciseOop1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseOop1.Repository
{


    public class UserRepository : IUserRepository
    {
        private AuthUser[] users = new AuthUser[10];
        private int count = 0;

        public UserRepository()
        {
            
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

        public AuthUser[] GetAll()
        {
            return users;
        }

    }
}
