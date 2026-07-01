using Blazor_Exercise.Dto;

namespace Blazor_Exercise.Interface
{
    public interface IUserService
    {
        Task<bool> Register(RegisterDto registerDto);
        Task<bool> Login(LoginDto loginDto);
        //Task Logout();
    }
}
