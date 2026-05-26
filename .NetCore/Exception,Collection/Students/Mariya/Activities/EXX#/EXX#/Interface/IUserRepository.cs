using EXX_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EXX_.Interface
{
    public interface IUserRepository
    {
        void Register(AuthUser user);
        AuthUser Login(string username, string password);

        AuthUser[] GetAll();

    }
}
