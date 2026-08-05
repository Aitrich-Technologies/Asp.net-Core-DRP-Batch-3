using Microsoft.EntityFrameworkCore;
using MVC_Exercise01.Interface;
using MVC_Exercise01.Models;

namespace MVC_Exercise01.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly AppDbContext _context;
        public AuthRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(AuthUser user)
        { 
            await _context.AuthUsers.AddAsync(user);
        }

        public async Task<AuthUser> GetByEmailAsync(string email)
        {
            return await _context.AuthUsers.FirstOrDefaultAsync(u => u.Email == email);
        }
        public async Task<AuthUser> GetByUserNameAsync(string username)
        {
            return await _context.AuthUsers.FirstOrDefaultAsync(u => u.UserName == username);
        }
        public async Task<AuthUser> GetByIdAsync(Guid id)
        {
            return await _context.AuthUsers.FindAsync(id);
        }
        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
