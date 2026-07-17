using Microsoft.EntityFrameworkCore;
namespace TourManagement.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext>options) 
            : base(options)
        {

        }

       public virtual DbSet<Guide>Guides { get; set; }
    public virtual DbSet<User> Users { get; set; }
       
    }
}
