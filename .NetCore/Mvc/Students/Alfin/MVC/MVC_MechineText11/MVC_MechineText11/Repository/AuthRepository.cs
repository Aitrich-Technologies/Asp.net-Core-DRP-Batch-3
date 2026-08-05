using Microsoft.EntityFrameworkCore;
using MVC_MechineText11.Interface;
using MVC_MechineText11.Models;
using Microsoft.EntityFrameworkCore;

namespace MVC_MechineText11.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly AppDbContext _context;
        public AuthRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Agency user)
        { 
         await _context.Agencies.AddAsync(user);
        }
        public async Task<Agency?> GetByEmailAsync(string email)
        { 
         return await _context.Agencies.FirstOrDefaultAsync(u => u.Email == email);
        }
        public async Task<Agency?> GetByUserNameAsync(string username)
        {
            return await _context.Agencies.FirstOrDefaultAsync(u => u.AgencyName == username);
        }
        public async Task<Agency> GetByIdAsync(Guid id) 
        {
            return await _context.Agencies.FindAsync(id);
        }
        public async Task SaveChangesAsync()
        { 
         await _context.SaveChangesAsync();
        }
    }
}
