using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin_Destination.Models;

namespace Admin_Destination.Interface
{
public interface IUserRepository
    {
        User Login(string email, string password);
        User[] GetAllAdmins();
        User GetLoggedUser();

        void AddCustomer(User user);

    }
}
