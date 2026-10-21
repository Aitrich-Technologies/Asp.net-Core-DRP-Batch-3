using Microsoft.EntityFrameworkCore;
using MVC_MechineText11.Helper;
using MVC_MechineText11.Interface;
using MVC_MechineText11.Models;
using MVC_MechineText11.Repository;
using MVC_MechineText11.Service;

namespace MVC_MechineText11.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(cfg => { }, typeof(AppProfile).Assembly);



            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IAuthService, AuthService>();

            services.AddScoped<ITourPackageRepository, TourPackageRepository>();

            services.AddScoped<ITourPackageService, TourPackageService>();
            return services;
        }
    }
}
