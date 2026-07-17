using Activity2.Data;
using Activity2.Interface;
using Activity2.Repository;
using Activity2.Service;
using Microsoft.EntityFrameworkCore;

namespace Activity2.Extension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddServiceExtensions(this IServiceCollection service, IConfiguration config)
        {
            service.AddDbContext<AppDbContext>(options =>
              options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            service.AddScoped<IUserRepository, UserRepository>();
            service.AddScoped<IUserService,UserService>();
            return service;
        }
    }
}
