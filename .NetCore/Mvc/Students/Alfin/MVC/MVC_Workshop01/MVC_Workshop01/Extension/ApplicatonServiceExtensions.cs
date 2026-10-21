using Microsoft.EntityFrameworkCore;
using MVC_Workshop01.Helper;
using MVC_Workshop01.Interface;
using MVC_Workshop01.Models;
using MVC_Workshop01.Repository;
using MVC_Workshop01.Services;

namespace MVC_Workshop01.Extension
{
    public static class ApplicatonServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            
            services.AddAutoMapper(cfg => { }, typeof(MappingProfile).Assembly);

            services.AddScoped<ITourBookingService, TourBookingService>();
            services.AddScoped<ITourBookingRepository, TourBookingRepository>();


            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IAuthService, AuthService>();
            return services;
        }
    }
}
