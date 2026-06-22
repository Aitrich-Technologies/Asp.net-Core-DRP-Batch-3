using Microsoft.EntityFrameworkCore;
namespace Razor_Activity3.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
