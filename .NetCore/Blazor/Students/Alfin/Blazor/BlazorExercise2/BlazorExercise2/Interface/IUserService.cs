using BlazorExercise2.Dto;

namespace BlazorExercise2.Interface
{
    public interface IUserService
    {
        Task<bool> Register(RegisterDto registerDto);
        Task<bool> Login(LoginDto loginDto);
    }
}
