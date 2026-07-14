using Login_Sample.Dto;
using Login_Sample.Models;

namespace Login_Sample.Interface
{
    public interface IAuthService
    {
        Task<(bool Success, string? Error)> RegisterAsync(RegisterDto user, string passwordPlain);
        Task<(bool Success, Auth? User, string? Error)> ValidateUserAsync(string usernameOrEmail, string passwordPlain);
    }
}
