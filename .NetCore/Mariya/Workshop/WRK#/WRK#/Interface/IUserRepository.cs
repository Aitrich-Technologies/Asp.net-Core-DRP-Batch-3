using System;
using System.Collections.Generic;
using System.Text;
using WRK_.Models;

namespace WRK_.Interface
{
    //internal class IUserRepository
    //{
        public interface IUserRepository
        {
            void Register(AuthUser user);
            AuthUser Login(string username, string password);
        }
}

