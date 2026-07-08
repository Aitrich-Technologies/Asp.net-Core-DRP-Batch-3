using Microsoft.EntityFrameworkCore;
using TourManagement.Helper;
using TourManagement.Interface;
using TourManagement.Models;
using TourManagement.Repository;
using TourManagement.Services;

namespace TourManagement.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationService(
            this IServiceCollection services,
            IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    config.GetConnectionString("DefaultConnection")));

            // Repository
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IGuideRepository, GuideRepository>();

            // Service
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IGuideService, GuideService>();

            // AutoMapper
            services.AddAutoMapper(cfg =>
                cfg.AddProfile<MappingProfile>());

            return services;
        }
    }
}