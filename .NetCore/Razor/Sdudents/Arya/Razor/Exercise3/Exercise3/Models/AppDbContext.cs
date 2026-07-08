using Microsoft.EntityFrameworkCore;
<<<<<<<< HEAD:.NetCore/Razor/Sdudents/Arya/Razor/Exercise3/Exercise3/Models/AppDbContext.cs
namespace Exercise3.Models
========

namespace MVC_Auth.Models
>>>>>>>> 72d82c91693b9e35788e1e94f879a16858273e20:.NetCore/Mvc/Activity/MVC-Auth/MVC-Auth/Models/AppDbContext.cs
{
    public class AppDbContext:DbContext
    {
<<<<<<<< HEAD:.NetCore/Razor/Sdudents/Arya/Razor/Exercise3/Exercise3/Models/AppDbContext.cs
         
        public AppDbContext(
            DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Destination> Destinations { get; set; }
========
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
>>>>>>>> 72d82c91693b9e35788e1e94f879a16858273e20:.NetCore/Mvc/Activity/MVC-Auth/MVC-Auth/Models/AppDbContext.cs
    }

}

