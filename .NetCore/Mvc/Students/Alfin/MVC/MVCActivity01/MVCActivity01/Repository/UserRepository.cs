using MVCActivity01.Interface;
using MVCActivity01.Models;
using Microsoft.EntityFrameworkCore;

namespace MVCActivity01.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetUserByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
        

        public async Task AddUserAsync(User user)
        { 
          await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
    }
}
