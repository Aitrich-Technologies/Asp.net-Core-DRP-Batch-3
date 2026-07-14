using AutoMapper;
using Exercise1.Dto;
using Exercise1.Enum;
using Exercise1.Interface;
using Exercise1.Models;

namespace Exercise1.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repository,
                           IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public User? Login(LoginDto loginDto)
        {
            return _repository.Login(
                loginDto.Email,
                loginDto.Password);
        }

        public void Register(RegisterDto registerDto)
        {
            var user = _mapper.Map<User>(registerDto);

            user.Role = UserRole.User;

            _repository.Register(user);
        }
    }
}