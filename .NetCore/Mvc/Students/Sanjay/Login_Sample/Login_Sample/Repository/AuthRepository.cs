using Login_Sample.Interface;
using Login_Sample.Models;
using Microsoft.EntityFrameworkCore;

namespace Login_Sample.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly AppDbContext _context;
        public AuthRepository(AppDbContext context) { _context = context; }

        public async Task CreateAsync(Auth user)
        {
            await _context.Users.AddAsync(user);
        }

        public async Task<Auth> GetByUserNameAsync(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserName == username);
        }

        public async Task<Auth> GetByIdAsync(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
