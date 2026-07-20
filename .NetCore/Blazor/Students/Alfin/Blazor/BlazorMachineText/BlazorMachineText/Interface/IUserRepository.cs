using BlazorMachineText.Dto;

namespace BlazorMachineText.Interface
{
    public interface IUserRepository
    {
        bool Login(string username, string password);
    }
}
