using AutoMapper;
using BlazorExercise2.Dto;
using BlazorExercise2.Interface;
using BlazorExercise2.Model;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace BlazorExercise2.Service
{
    public class UserService :IUserService
    {
        private readonly ProtectedSessionStorage _sessionStorage;
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper, ProtectedSessionStorage protectedSessionStorage)
        {
            _sessionStorage = protectedSessionStorage;
            _repository = userRepository;
            _mapper = mapper;
        }

        public async Task<bool> Register(RegisterDto registerDto)
        {
            var existingUser = await _repository.GetByEmailAsync(registerDto.Email);
            if (existingUser == null)
            {
                var register = _mapper.Map<Users>(registerDto);
                register.PasswordHash = BCrypt.Net.BCrypt.HashPassword(registerDto.Password);
                await _repository.AddAsync(register);
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> Login(LoginDto loginDto)
        {
            var register = await _repository.GetByEmailAsync(loginDto.Email);
            if (register == null || !BCrypt.Net.BCrypt.Verify(loginDto.Password, register.PasswordHash))

                return false;

            try
            {
                await _sessionStorage.SetAsync("RegisterId", register.Id);
                await _sessionStorage.SetAsync("RegisterEmail", register.Email);
                Console.WriteLine("Session stored successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Session error: " + ex.ToString());
            }
            return true;
        }
    }
}
