    using Microsoft.EntityFrameworkCore;
    namespace MachineTest.Model
    {
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            
            }
            public DbSet<Student> students { get; set; }
        }
    }

       
    

