using BlazorActivity02.Data;
using BlazorActivity02.Interface;
using BlazorActivity02.Repository;
using BlazorActivity02.Service;
using Microsoft.EntityFrameworkCore;

namespace BlazorActivity02.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            
             
            return services;
        }
    }
}
