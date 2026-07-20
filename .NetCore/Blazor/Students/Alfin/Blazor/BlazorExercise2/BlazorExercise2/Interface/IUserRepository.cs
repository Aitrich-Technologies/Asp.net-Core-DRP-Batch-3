using BlazorExercise2.Model;

namespace BlazorExercise2.Interface
{
    public interface IUserRepository
    {
        Task AddAsync(Users users);
        Task<Users> GetByEmailAsync(string email);
    }
}
