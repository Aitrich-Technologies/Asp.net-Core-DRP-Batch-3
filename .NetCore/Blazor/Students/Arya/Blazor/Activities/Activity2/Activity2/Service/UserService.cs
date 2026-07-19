using Activity2.Data;
using Activity2.Dto;
using Activity2.Interface;

namespace Activity2.Service
{
    public class UserService:IUserService
       
    {
        private readonly IUserRepository _repository;
        public UserService (IUserRepository repository)

        {  _repository = repository; 
        }
        public void Register(RegisterDto dto)
        {
            User user = new User();
            user.Name = dto.Name;
            user.Email = dto.Email;
            user.Password = dto.Password;
           _repository .Add(user);

        }
        public bool Login(LoginDto dto)
        {
            User user = _repository.GetUser(dto.Email, dto.Password);

            return user != null;
        }


    }
}
