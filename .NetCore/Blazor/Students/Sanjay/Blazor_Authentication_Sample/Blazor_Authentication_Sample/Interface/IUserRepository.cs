using Blazor_Authentication_Sample.Data;

namespace Blazor_Authentication_Sample.Interface
{
    public interface IUserRepository
    {
        void AddUser(Users user);

        Users GetUsers(string email, string password);
    }
}
