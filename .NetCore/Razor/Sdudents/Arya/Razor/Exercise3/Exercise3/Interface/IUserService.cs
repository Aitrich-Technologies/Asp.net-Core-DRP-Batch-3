using Exercise3.Dto;
using Exercise3.Models;

namespace Exercise3.Interface
{
    public interface IUserService
    {
        Task<bool> Register(UserDto userDto);

        Task<User?> Login(LoginDto loginDto);

        Task<List<User>> GetAllUsers();

        Task<User?> GetById(int id);
    }
}