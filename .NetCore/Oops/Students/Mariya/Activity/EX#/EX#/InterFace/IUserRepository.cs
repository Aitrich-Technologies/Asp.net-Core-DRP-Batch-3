using EX_.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EX_.InterFace
{
    public interface IUserRepository
    {

        void Add(AuthUser user);
        AuthUser[] GetAllUsers();
        AuthUser GetById(int id);
    }
}

