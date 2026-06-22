using Microsoft.EntityFrameworkCore;

namespace Workshop_Razor.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Tours> Tours { get; set; }
    }
}
