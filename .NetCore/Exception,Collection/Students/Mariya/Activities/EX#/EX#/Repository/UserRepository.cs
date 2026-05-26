using EX_.InterFace;
using EX_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EX_.Repository
{
    public class UserRepository : IUserRepository
    {
        private AuthUser[] users = new AuthUser[0];

        public void Add(AuthUser user)
        {
            var newArr = new AuthUser[users.Length + 1];
            for (int i = 0; i < users.Length; i++)
                newArr[i] = users[i];

            newArr[^1] = user;
            users = newArr;
        }

        public AuthUser[] GetAll() => (AuthUser[])users.Clone();

        public AuthUser[] GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public AuthUser GetById(int id)
        {
            foreach (var u in users)
                if (u.UserId == id) return u;
            return null;
        }
    }
}
