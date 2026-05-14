using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise1.Models;

namespace Excercise1.Interface
{
  public interface IUserRepository
    {
        void Register(User user);
        User Login(string email, string password);
        List<User> GetAll();
    }
}
