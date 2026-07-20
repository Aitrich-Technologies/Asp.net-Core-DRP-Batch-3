using BlazorMachineText.Dto;
using BlazorMachineText.Interface;

namespace BlazorMachineText.Service
{
    public class UserService :IUserSevice
    {
        public bool Login(string username, string password)
        {
            return username == "admin" && password == "1234";
        }
    }
}

