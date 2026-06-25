using AutoMapper;
using MachineTest.Dto;
using MachineTest.Interface;
using MachineTest.Models;

namespace MachineTest.Service
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
        public async Task<bool> RegisterAsync(UserDto dto)
        {
            var existingUser = await _repo.GetByUserNameAsync(dto.UserName);
            if (existingUser != null)
                return false;

            var user = _mapper.Map<User>(dto);
            //user.Id = Guid.NewGuid();


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
    }
}
