using Microsoft.EntityFrameworkCore;

namespace Activitylogin.Model
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> users { get; set; }
    }
}
