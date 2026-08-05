using Microsoft.EntityFrameworkCore;
namespace MVC_Exercise01.Models
    
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
               : base(options)
        {
        }

        public virtual DbSet<AuthUser> AuthUsers { get; set; }

        public virtual DbSet<Destination> Destinations { get; set; }

       
    }



}
