using RazorExercise1.Dto;
using RazorExercise1.Model;

namespace RazorExercise1.Interface
{
    public interface IRegisterService
    {
        public Task AddUserAsync(RegisterDto registerDto);
        //public Task<User> LoginAsync(UserDto userDto);
        public Task<Register> GetByUsernameAndPasswordAsync(string Username, string Password);
    }
}
