using BlazorMachineText.Dto;
using BlazorMachineText.Interface;

namespace BlazorMachineText.Repository
{
    public class UserRepository : IUserRepository
    {
        public bool Login(string username, string password)
        {
            if (username == "admin" && password == "1234")
            {
                return true;
            }

            return false;
        }
    }

}
