using Exercise1.Dto;
using Exercise1.Models;

namespace Exercise1.Interface
{
    public interface IUserService
    {
        User? Login(LoginDto loginDto);

        void Register(RegisterDto registerDto);
    }
}