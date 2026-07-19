using Login.Interfacce;
using Login.Model;
using Microsoft.EntityFrameworkCore;

namespace Login.Repository
{
    public class UserRepository :IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository (AppDbContext context)
        {
            _context = context;
        }

        public async Task <User?> GetByUserNameAsync (string userName)
        {
           return await _context.Users.FirstOrDefaultAsync(u  => u.UserName == userName);
        }
        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
        }
        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
        }
        public async Task SaveAsync ()
        {
            await _context .SaveChangesAsync();
        }

       
    }
}
