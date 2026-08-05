using MVC_Workshop01.Dto;
using MVC_Workshop01.Models;

namespace MVC_Workshop01.Interface
{
    public interface IAuthService
    {
        Task<(bool Success, string? Error)> RegisterAsync(AuthUserDto user, string passwordPlain);
        Task<(bool Success, AuthUser? User, string? Error)> ValidateUserAsync(string usernameOrEmail, string passwordPlain);
    }
}
