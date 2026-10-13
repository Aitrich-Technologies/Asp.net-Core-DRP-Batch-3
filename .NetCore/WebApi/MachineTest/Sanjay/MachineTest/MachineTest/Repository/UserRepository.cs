using MachineTest.Interface;
using MachineTest.Models;
using Microsoft.EntityFrameworkCore;

namespace MachineTest.Repository
{
    public class UserRepository : IUserRepository
    {
        public readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User> RegisterAsync(User user)
        {
            var existing = await _context.Users.FirstOrDefaultAsync(u => u.Email  == user.Email);
            if (existing != null)
                return null;

            var u =  _context.Users.Add(user);
            _context.SaveChangesAsync();
            return user;
        }

        public async Task<User?> LoginAsync(string email, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);

            if (user == null)
                return null;

            return user;
        }
    }
}
