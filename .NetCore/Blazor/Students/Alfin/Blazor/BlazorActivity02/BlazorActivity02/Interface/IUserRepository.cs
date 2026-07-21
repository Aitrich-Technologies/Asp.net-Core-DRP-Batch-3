using BlazorActivity02.Data;

namespace BlazorActivity02.Interface
{
    public interface IUserRepository
    {
        void AddUser(User user);
        User GetUser(string email, string password);



    }
}
