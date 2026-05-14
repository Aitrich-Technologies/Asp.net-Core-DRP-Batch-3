using ExerciseOop1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseOop1.Interface
{
    public interface IUserRepository
    {
        void Register(AuthUser user);
        AuthUser Login(string username, string password);

        AuthUser[] GetAll();
    }

}
