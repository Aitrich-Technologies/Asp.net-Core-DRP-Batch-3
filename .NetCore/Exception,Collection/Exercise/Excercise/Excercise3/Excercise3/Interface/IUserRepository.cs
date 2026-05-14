using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excercise3.Models;

namespace Excercise3.Interface
{

        public interface IUserRepository
        {
            void Register(User user);

            User Login(string email, string password);

          
            List<User> getAllAgent();
        }
    }


