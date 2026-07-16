using Exercise2.Helper;
using Exercise2.Interface;
using Exercise2.Models;
using Exercise2.Repository;
using Exercise2.Service;
using Microsoft.EntityFrameworkCore;

namespace Exercise2.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
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