using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services.User.Interface
{
    public interface IUserRepository
    {
        Task<AuthUser> AddUserAsync(AuthUser user);
        Task<AuthUser?> GetByUserNameOrEmailAsync(string username, string email);
        Task<AuthUser> LoginAsync(string username, string password);
        Task<AuthUser> GetByEmailAsync(string email);
        Task<AuthUser> GetUserByIdAsync(Guid userId);
        Task<AuthUser> UpdateUserAsync(AuthUser user);
    }
}
