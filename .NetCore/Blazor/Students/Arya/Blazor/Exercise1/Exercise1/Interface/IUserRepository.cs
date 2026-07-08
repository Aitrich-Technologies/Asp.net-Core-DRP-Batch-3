using Exercise1.Models;

namespace Exercise1.Interface
{
    public interface IUserRepository
    {
        User? Login(string email, string password);

        void Register(User user);
    }
}