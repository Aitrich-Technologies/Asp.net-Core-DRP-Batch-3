using Auth_Sample.Models;
using Auth_Sample.Service;
using Auth_Sample.Interface;
using Auth_Sample.Repository;
using Auth_Sample.Helper;
using Microsoft.EntityFrameworkCore;

namespace Auth_Sample.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
          (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(cfg => { }, typeof(MappingProfile));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();


            return services;

        }
    }
}