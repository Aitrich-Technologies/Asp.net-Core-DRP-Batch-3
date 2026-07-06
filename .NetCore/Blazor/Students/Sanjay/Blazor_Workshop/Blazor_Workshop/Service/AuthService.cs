using Blazor_Workshop.Dto;
using Blazor_Workshop.Interface;
using AutoMapper;
using Blazor_Workshop.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;


namespace Blazor_Workshop.Service
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly ProtectedSessionStorage _sessionStorage;
        private readonly IMapper _mapper;
        public AuthService(IAuthRepository authRepository, ProtectedSessionStorage sessionStorage, IMapper mapper)
        {
            _authRepository = authRepository;
            _mapper = mapper;
            _sessionStorage = sessionStorage;
        }
        public async Task<bool> Register(RegisterDto registerDto, string pssword)
        {
            var existingUser = await _authRepository.GetByEmailAsync(registerDto.Email);
            if(existingUser != null) 
            {
                return false;
            }
            else
            {
                Console.WriteLine($"Name: {registerDto.Name}");
                Console.WriteLine($"Email: {registerDto.Email}");

                var register = _mapper.Map<Register>(registerDto);
                register.PasswordHash = BCrypt.Net.BCrypt.HashPassword(pssword);
                Console.WriteLine($"Mapped Email: {register.Email}");
                await _authRepository.AddAsync(register);
                return true;
            }
        }

        public async Task<bool> Login(string email, string password)
        {
            var register = await _authRepository.GetByEmailAsync(email);
            if (register == null || !BCrypt.Net.BCrypt.Verify(password, register.PasswordHash))
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
