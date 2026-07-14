using MachineTest.Interface;
using MachineTest.Models;
using Microsoft.EntityFrameworkCore;

namespace MachineTest.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly AppDbContext _context;

        public AuthRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Auth user)
        {
            await _context.Users.AddAsync(user);
        }

        public async Task<Auth> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
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
