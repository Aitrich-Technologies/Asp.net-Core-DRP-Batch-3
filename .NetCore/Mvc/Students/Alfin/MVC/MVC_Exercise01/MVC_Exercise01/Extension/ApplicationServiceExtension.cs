using Microsoft.EntityFrameworkCore;
using MVC_Exercise01.Helper;
using MVC_Exercise01.Interface;
using MVC_Exercise01.Models;
using MVC_Exercise01.Repository;
using MVC_Exercise01.Service;

namespace MVC_Exercise01.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(cfg => { }, typeof(AppProfile).Assembly);

            services.AddScoped<IDestinationService, DestinationService>();
            services.AddScoped<IDestinationRepository, DestinationRepository>();

            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IAuthService, AuthService>();

            return services;
        }
    }
}
