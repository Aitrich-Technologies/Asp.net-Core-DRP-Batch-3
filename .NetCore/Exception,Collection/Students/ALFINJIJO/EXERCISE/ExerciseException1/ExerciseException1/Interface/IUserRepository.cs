using ExerciseException1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciseException1.Interface
{
    public interface IUserRepository
    {
        User Login(string email, string password);
        void AddUser(User user);
        List<User> GetConsultants();

       
    }
}
