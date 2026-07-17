using Exercise3.Models;

namespace Exercise3.Interface
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUsers();

        Task<User?> GetById(int id);

        Task<User?> GetByEmail(string email);

        Task AddUser(User user);

        Task Save();
    }
}
