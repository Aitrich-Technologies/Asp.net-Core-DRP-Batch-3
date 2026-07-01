using Blazor_Authentication_Sample.Data;
using Blazor_Authentication_Sample.Interface;

namespace Blazor_Authentication_Sample.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddUser(Users users)
        {
            _context.Users.Add(users);
            _context.SaveChanges();
        }

        public Users GetUsers(string email, string password)
        {
            var existingUser = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            return existingUser;
        }

    }
}
