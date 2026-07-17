using Login_Sample.Helpers;
using Login_Sample.Interface;
using Login_Sample.Models;
using Login_Sample.Repository;
using Login_Sample.Service;
using Microsoft.EntityFrameworkCore;

namespace Login_Sample.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );

            services.AddAutoMapper(cfg => { }, typeof(MappingProfile));

            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IAuthService, AuthService>();

            return services;
        }
    }
}
