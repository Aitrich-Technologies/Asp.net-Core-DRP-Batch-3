using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;
using workshopOOP.Model;

namespace workshopOOP.Interface
{
    public interface IUserRepository
    {
        void Register(AuthUser user);
        AuthUser Login(string username, string password);
    }
}
