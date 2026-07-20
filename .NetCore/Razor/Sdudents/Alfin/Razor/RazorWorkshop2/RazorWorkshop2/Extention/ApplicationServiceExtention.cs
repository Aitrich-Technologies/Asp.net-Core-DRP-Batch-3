using Microsoft.EntityFrameworkCore;
using RazorWorkshop2.Helper;
using RazorWorkshop2.Interfaces;
using RazorWorkshop2.Models;
using RazorWorkshop2.Repository;
using RazorWorkshop2.Service;

namespace RazorWorkshop2.Extention
{
    public static class ApplicationServiceExtention
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );

            services.AddAutoMapper(cfg => cfg.AddProfile<MappingProfile>());

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}