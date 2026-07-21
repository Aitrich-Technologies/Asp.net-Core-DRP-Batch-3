using BlazorMachineText.Dto;

namespace BlazorMachineText.Interface
{
    public interface IUserSevice
    {
        bool Login(string username, string password);
    }
}
