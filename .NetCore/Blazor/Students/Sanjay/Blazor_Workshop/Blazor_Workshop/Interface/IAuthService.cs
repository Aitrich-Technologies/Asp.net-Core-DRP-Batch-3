using Blazor_Workshop.Dto;
namespace Blazor_Workshop.Interface
{
    public interface IAuthService
    {
        Task<bool> Register(RegisterDto registerDto, string password);
        Task<bool> Login(string email, string password);
        //Task Logout();
    }
}
