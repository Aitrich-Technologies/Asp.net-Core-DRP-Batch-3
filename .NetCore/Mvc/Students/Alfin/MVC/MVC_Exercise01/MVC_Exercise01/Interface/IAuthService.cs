using MVC_Exercise01.Dto;
using MVC_Exercise01.Models;

namespace MVC_Exercise01.Interface
{
    public interface IAuthService
    {
        Task<(bool Success, string? Error)> RegisterAsync(AuthUserDto user, string PasswordPlain);
        Task<(bool Success, AuthUser? User, string? Error)> ValidateUserAsync(string usernameOrEmail, string passwordPlain);
    }
}
