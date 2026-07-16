using Login.Model;

namespace Login.Interfacce
{
    public interface IUserRepository
    {
        Task<User> GetByUserNameAsync(string userName);
        Task AddAsync (User user);
        Task UpdateAsync (User user);
        Task SaveAsync();

    }
}
