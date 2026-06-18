using Exercise.Dto;
using Exercise.Models;

namespace Exercise.Interface
{
    public interface IRegisterRepository
    {
        public Task AddUserAsync(RegisterDto registerDto);
        //public Task<User> LoginAsync(UserDto userDto);
        public Task<Register> GetByUsernameAndPasswordAsync(string Username, string Password);

    }
}
