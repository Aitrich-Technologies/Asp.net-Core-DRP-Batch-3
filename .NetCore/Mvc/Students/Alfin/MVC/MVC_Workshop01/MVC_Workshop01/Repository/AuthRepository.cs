using MVC_Workshop01.Interface;
using MVC_Workshop01.Models;
using Microsoft.EntityFrameworkCore;

namespace MVC_Workshop01.Repository
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
         await _context.Users.AddAsync(user);
        }
        public async Task<AuthUser?> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
       
        }

        public async Task<AuthUser?> GetByUserNameAsync(string username)
        { 
         return  await _context.Users.FirstOrDefaultAsync(u =>u.UserName == username);
        }

        public async Task<AuthUser> GetByIdAsync(Guid Id)
        {
            return await _context.Users.FindAsync(Id);
        }

        public async Task SaveChangesAsync()
        { 
         await _context.SaveChangesAsync();
        }

    }
}
