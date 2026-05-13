using System;
using System.Collections.Generic;
using System.Text;
using exercise1.Models;

namespace exercise1.Interface
{
    //internal class IUserRepository
    //{
        public interface IUserRepository
        {
            void Register(AuthUser user);
            AuthUser Login(string username, string password);
        }
}

