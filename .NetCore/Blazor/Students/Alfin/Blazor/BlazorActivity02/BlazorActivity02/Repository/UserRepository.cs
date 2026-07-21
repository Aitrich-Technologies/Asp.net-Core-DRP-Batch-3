using BlazorActivity02.Data;
using BlazorActivity02.Interface;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace BlazorActivity02.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public UserRepository(AppDbContext context)
        {
            _context = context;

        }

    public void AddUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();

    }
        public User GetUser(string email, string password)
        { var existinguser = _context.Users.FirstOrDefault(U => U.Email == email && U.Password == password);
            return existinguser;
        }
}
    
}
