using Domain.Models;
using Domain.Services.User.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services.User
{
    public class UserRepository : IUserRepository
    {
        private readonly TourDbContext _context;

        public UserRepository(TourDbContext context)
        {
            _context = context;
        }

        public async Task<AuthUser> AddUserAsync(AuthUser user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }
        public async Task<AuthUser> LoginAsync(string username, string password)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.UserName == username);

            if (user == null)
                return null;

           
            bool isPasswordValid = BCrypt.Net.BCrypt.Verify(password, user.Password);
            if (!isPasswordValid)
                return null;

            return user;
        }

        public async Task<AuthUser> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }


        public async Task<AuthUser?> GetByUserNameOrEmailAsync(string userName, string email)
        {
            return await _context.Users
                .FirstOrDefaultAsync(u => u.UserName == userName || u.Email == email);
        }
        public async Task<AuthUser> GetUserByIdAsync(Guid userId)
        {
            return await _context.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Id == userId);
        }

        public async Task<AuthUser> UpdateUserAsync(AuthUser user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
            return user;
        }

    }
}
