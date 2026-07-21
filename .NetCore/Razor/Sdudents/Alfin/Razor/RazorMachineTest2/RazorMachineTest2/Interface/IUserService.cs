using RazorMachineTest2.Dtos;
using RazorMachineTest2.Models;

namespace RazorMachineTest2.Interface
{
    public interface IUserService
    {
        Task<bool> RegisterAsync(RegisterDto dto);
        Task<User?> LoginAsync(LoginDto dto);
    }
}
