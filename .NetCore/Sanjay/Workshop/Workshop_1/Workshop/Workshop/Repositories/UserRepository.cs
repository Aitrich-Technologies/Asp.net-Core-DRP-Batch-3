using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Interface;
using Workshop.Models;

namespace Workshop.Repositories
{
    internal class UserRepository : IUserRepository
    {
        private AuthUser[] users = new AuthUser[0];

        public void Add(AuthUser user)
        {
            var newArr = new AuthUser[users.Length + 1];
            for (int i = 0; i < users.Length; i++)
                newArr[i] = users[i];

            newArr[users.Length] = user;
            users = newArr;
        }

        public AuthUser[] GetAll() => users;

        public AuthUser GetById(int id)
        {
            foreach (var u in users)
                if (u.UserId == id) return u;
            return null;
        }
    }
}
