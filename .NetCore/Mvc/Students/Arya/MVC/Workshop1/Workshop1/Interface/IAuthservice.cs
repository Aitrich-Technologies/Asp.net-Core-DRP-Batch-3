using Workshop1.Dto;
using Workshop1.Models;

namespace Workshop1.Interface
{
    public interface IAuthservice
    {
        Task<(bool Success, string? Error)> RegisterAsync(AuthUserDto user, string passwordPlain);
        Task<(bool Success, User? User, string? Error)> ValidateUserAsync(string usernameOrEmail, string passwordPlain);
    }
}
