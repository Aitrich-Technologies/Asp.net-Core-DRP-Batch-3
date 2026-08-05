
using Microsoft.EntityFrameworkCore;

namespace MVC_MechineText11.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Agency> Agencies { get; set; }
        public DbSet<TourPackage> TourPackages { get; set; }
    }
}
