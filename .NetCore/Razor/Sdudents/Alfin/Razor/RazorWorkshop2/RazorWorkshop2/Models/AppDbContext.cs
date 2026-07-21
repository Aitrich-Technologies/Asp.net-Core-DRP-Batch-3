using Microsoft.EntityFrameworkCore;

namespace RazorWorkshop2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        
        
    }
}
