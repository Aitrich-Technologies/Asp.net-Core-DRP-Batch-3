
using Exercise1.Interface;
using Exercise1.Models;

namespace Exercise1.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public User? Login(string email, string password)
        {
            return _context.Users.FirstOrDefault(x =>
                   x.Email == email &&
                   x.Password == password);
        }

        public void Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
    }
}