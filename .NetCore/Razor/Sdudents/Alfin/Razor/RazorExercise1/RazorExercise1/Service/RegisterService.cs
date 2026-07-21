using RazorExercise1.Dto;
using RazorExercise1.Interface;
using RazorExercise1.Model;
using RazorExercise1.Repository;

namespace RazorExercise1.Service
{
    public class RegisterService : IRegisterService
    {
        private readonly RegisterRepository registerRespository;
        public RegisterService(RegisterRepository _registerRespository)
        {
            registerRespository = _registerRespository;
        }
        public async Task AddUserAsync(RegisterDto registerDto)
        {
            await registerRespository.AddUserAsync(registerDto);
        }

        public async Task<Register> GetByUsernameAndPasswordAsync(string Username, string Password)
        {
            return await registerRespository.GetByUsernameAndPasswordAsync(Username, Password);
        }
    }
}
