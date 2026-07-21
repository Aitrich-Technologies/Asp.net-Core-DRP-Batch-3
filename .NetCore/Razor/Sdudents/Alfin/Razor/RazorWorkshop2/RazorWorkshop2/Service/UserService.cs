using AutoMapper;
using Microsoft.Identity.Client;
using RazorWorkshop2.Dtos;
using RazorWorkshop2.Interfaces;
using RazorWorkshop2.Models;

namespace RazorWorkshop2.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<bool> RegisterAsync(UserRegisterDto dto)
        {
            var existingUser = await _repo.GetByUserNameAsync(dto.UserName);
            if (existingUser != null)
                return false;

            var user = _mapper.Map<User>(dto);
            user.Id = Guid.NewGuid();
            user.Role = Enum.UserRole.CONSULTANT;

            await _repo.AddAsync(user);
            await _repo.SaveAsync();

            return true;



        }
        public async Task<User?> LoginAsync(UserLoginDto dto)
        {
            var user = await _repo.GetByUserNameAsync(dto.UserName);
            if (user == null || user.Password != dto.Password)
                return null;

            return user;
        }

        public async Task<bool> ChangePasswordAsync(UserchangePasswordDto dto)
        {
            var user = await _repo.GetByUserNameAsync(dto.UserName);
            if (user == null || user.Password != dto.CurrentPassword)
                return false;

            user.Password = dto.NewPassword;
            await _repo.UpdateAsync(user);
            await _repo.SaveAsync();
            return true;
        }


    }
}
