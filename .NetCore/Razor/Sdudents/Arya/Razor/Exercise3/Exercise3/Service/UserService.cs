using AutoMapper;
using Exercise3.Dto;
using Exercise3.Interface;
using Exercise3.Models;

namespace Exercise3.Service
{
    public class UserService:IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(
            IUserRepository userRepository,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<bool> Register(UserDto userDto)
        {
            var existingUser =
                await _userRepository.GetByEmail(userDto.Email);

            if (existingUser != null)
                return false;

            var user = _mapper.Map<User>(userDto);

            await _userRepository.AddUser(user);

            await _userRepository.Save();

            return true;
        }

        public async Task<User?> Login(LoginDto loginDto)
        {
            var user =
                await _userRepository.GetByEmail(loginDto.Email);

            if (user == null)
                return null;

            if (user.Password != loginDto.Password)
                return null;

            return user;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _userRepository.GetAllUsers();
        }

        public async Task<User?> GetById(int id)
        {
            return await _userRepository.GetById(id);
        }
    }
}
