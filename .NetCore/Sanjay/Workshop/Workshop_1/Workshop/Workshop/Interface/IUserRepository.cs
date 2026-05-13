using System;
using System.Collections.Generic;
using System.Text;
using Workshop.Models;

namespace Workshop.Interface
{
    internal interface IUserRepository
    {
        void Add(AuthUser user);
        AuthUser[] GetAll();
        AuthUser GetById(int id);
    }
}
