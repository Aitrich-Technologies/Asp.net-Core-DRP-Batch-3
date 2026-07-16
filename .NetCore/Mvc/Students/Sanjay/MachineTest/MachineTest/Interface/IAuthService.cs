using MachineTest.Dto;
using MachineTest.Models;

namespace MachineTest.Interface
{
    public interface IAuthService
    {
        Task<(bool Success, string? Error)> RegisterAsync(AuthUserDto user, string passwordPlain);
        Task<(bool Success, Auth? User, string? Error)> ValidateUserAsync(string Email, string passwordPlain);
    }
}
