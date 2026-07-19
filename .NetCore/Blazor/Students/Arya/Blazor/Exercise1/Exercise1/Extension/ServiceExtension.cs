
using Exercise1.Helper;
using Exercise1.Interface;
using Exercise1.Models;
using Exercise1.Repository;
using Exercise1.Service;
using Microsoft.EntityFrameworkCore;

namespace Exercise1.Extension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddProjectServices(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            // Database Connection
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            // Repository Registration
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITourRepository, TourRepository>();

            // Service Registration
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITourService, TourService>();
            // AutoMapper Configuration
            services.AddAutoMapper(cfg => { }, typeof(MappingProfile));

            return services;
        }
    }
}