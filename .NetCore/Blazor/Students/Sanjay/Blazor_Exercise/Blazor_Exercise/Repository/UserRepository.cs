using Blazor_Exercise.Interface;
using Blazor_Exercise.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Exercise.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository (AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Users users)
        {
            _context.Users.Add(users);
            await _context.SaveChangesAsync();
        }

        public async Task<Users> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
}
}
