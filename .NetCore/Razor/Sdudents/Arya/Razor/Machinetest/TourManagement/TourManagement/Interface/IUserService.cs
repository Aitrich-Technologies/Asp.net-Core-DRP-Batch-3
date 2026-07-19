using TourManagement.Dto;
using TourManagement.Models;

public interface IUserService
{
    Task<List<User>> GetAllUsersAsync();
    Task<User> GetUserByIdAsync(int id);
    Task AddUserAsync(User user);
    Task UpdateUserAsync(User user);

    Task RegisterAsync(RegisterDto dto);

    Task<User?> LoginAsync(LoginDto login);
}