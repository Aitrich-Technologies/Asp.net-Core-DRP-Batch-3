using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Enum;
using Workshop.Interface;
using Workshop.Models;

namespace Workshop.Managers
{
    internal class UserManager
    {
        private IUserRepository repo;

        public UserManager(IUserRepository repo)
        {
            this.repo = repo;
        }

        public void Register(string username, string password, UserRoles role)
        {

            repo.Add(new AuthUser
            {
                UserId = new Random().Next(1000),
                Username = username,
                Password = password,
                Role = role
            });
        }

        public AuthUser Login(string username, string password)
        {
            foreach (var u in repo.GetAll())
                if (u.Username == username && u.Password == password)
                    return u;

            return null;
        }
    }
}
