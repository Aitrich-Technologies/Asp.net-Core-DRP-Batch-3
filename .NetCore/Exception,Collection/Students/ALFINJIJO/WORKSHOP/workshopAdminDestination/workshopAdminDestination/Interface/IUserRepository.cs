using System;
using System.Collections.Generic;
using System.Text;
using workshopAdminDestination.Models;

namespace workshopAdminDestination.Interface
{
    public interface IUserRepository
    {
        User Login(string email, string password);
        List<User> GetAllAdmins();
        User GetLoggedUser();
    }
}
    

