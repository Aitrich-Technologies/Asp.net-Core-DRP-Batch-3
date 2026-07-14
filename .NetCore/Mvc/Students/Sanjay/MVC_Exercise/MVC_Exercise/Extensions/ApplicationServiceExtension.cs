using Microsoft.EntityFrameworkCore;
using MVC_Exercise.Helper;
using MVC_Exercise.Interface;
using MVC_Exercise.Models;
using MVC_Exercise.Service;
namespace MVC_Exercise.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DestinationDbContext>(options =>
               options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );
            services.AddAutoMapper(cfg => { }, typeof(AppProfile));

            services.AddScoped<IDestinationService, DestinationService>();
            services.AddScoped<IDestinationRepository, DestinationRepository>();


            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IAuthService, AuthService>();


            return services;
        }
    }
}
