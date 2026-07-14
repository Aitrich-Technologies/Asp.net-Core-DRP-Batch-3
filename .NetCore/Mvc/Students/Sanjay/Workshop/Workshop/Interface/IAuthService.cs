using Workshop.Dto;
using Workshop.Models;

namespace Workshop.Interface
{
    public interface IAuthService
    {
        Task<(bool Success, string? Error)> RegisterAsync(AuthUserDto user, string passwordPlain);
        Task<(bool Success, AuthUser? User, string? Error)> ValidateUserAsync(string usernameOrEmail, string passwordPlain);

    }
}
