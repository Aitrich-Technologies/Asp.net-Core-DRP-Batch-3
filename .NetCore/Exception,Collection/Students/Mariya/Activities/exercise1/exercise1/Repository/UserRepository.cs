using System;
using System.Collections.Generic;
using System.Text;
using exercise1.Interface;
using exercise1.Models;

namespace exercise1.Repository
{
    //internal class UserRepository
    //{
        public class UserRepository : IUserRepository
        {
            private AuthUser[] users = new AuthUser[10];
            private int count = 0;

            public UserRepository()
            {
                // Default Agency
                users[count++] = new AuthUser
                {
                    UserId = 1,
                    UserName = "admin",
                    Password = "admin",
                    Roles = Enum.UserRoles.Agency
                };
            }
            public void Register(AuthUser user)
            {
                users[count++] = user;
            }

            public AuthUser Login(string username, string password)
            {
                for (int i = 0; i < count; i++)
                {
                    if (users[i].UserName == username && users[i].Password == password)
                        return users[i];
                }
                return null;
            }
        }

    }

