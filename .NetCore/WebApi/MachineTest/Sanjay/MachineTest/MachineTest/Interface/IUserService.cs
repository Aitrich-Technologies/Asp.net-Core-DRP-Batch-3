using MachineTest.DTOs;
using MachineTest.Models;

namespace MachineTest.Interface
{
    public interface IUserService
    {
        Task<RegisterDto> RegisterAsync(RegisterDto dto);
        Task<string> LoginAsync(LoginDto loginDto);
    }
}
