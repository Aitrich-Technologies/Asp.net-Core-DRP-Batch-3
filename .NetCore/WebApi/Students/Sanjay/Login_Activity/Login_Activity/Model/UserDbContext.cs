using Microsoft.EntityFrameworkCore;
namespace Login_Activity.Model
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> users { get; set; }

    }
}
