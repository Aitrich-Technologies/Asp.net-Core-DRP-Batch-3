using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise2.Models;

namespace Excercise2.Interface
{
    public interface IUserRepository
    {
        User Login(string email, string password);
        void AddUser(User user);
        List<User> GetConsultants();
    }
}
