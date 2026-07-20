using BlazorActivity02.Dtos;

namespace BlazorActivity02.Interface
{
    public interface IUserService
    {
        void Register(RegisterDto registerDto);
        bool Login(LoginDto loginDto);
    }
}
