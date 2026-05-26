using EX_.Enum;
using EX_.InterFace;
using EX_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EX_.Manager
{
    public class UserManager
    {
        private IUserRepository repo;
        private int idCounter = 1;

        public UserManager(IUserRepository repo)
        {
            this.repo = repo;
        }

        public void Register(string username, string password, UserRoles role)
        {
            repo.Add(new AuthUser
            {
                UserId = idCounter++,
                Username = username,
                Password = password,
                Role = role
            });
        }

        public AuthUser Login(string username, string password)
        {
            foreach (var user in repo.GetAllUsers())
            {
                if (user.Username == username && user.Password == password)
                    return user;
            }
            return null;
        }

        internal object GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
