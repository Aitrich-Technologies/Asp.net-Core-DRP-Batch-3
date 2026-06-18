using MachineTest.Dto;
using MachineTest.Models;
namespace MachineTest.Interface
{
    public interface IUserService
    {
        Task<bool> RegisterAsync(UserDto dto);         
        Task<User?> LoginAsync(UserLoginDto dto);
    }
}
