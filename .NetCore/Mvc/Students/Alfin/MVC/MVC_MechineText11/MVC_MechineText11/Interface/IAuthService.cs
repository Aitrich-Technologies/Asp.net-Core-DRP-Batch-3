using MVC_MechineText11.Dto;
using MVC_MechineText11.Models;

namespace MVC_MechineText11.Interface
{
    public interface IAuthService
    {
        Task<(bool Success, string? Error)> RegisterAsync(RegisterDto user, string passwordPlain);
        Task<(bool Success, Agency? User, string? Error)> ValidateUserAsync(string Email, string passwordPlain);
    }
}
