using Microsoft.EntityFrameworkCore;
namespace Workshop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Destination>Destinations {  get; set; }
        
        
    }
}
