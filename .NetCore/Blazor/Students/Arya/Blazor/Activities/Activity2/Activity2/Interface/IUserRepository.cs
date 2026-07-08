using Activity2.Data;

namespace Activity2.Interface
{
    public interface IUserRepository
    {
        void Add(User user);
        User GetUser(string Email,string Password);
    }
}
