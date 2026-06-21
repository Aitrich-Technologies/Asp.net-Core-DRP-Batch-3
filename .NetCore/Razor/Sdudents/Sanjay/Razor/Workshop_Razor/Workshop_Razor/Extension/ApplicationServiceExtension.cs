using Microsoft.EntityFrameworkCore;
using Workshop_Razor.Helper;
using Workshop_Razor.Models;
using Workshop_Razor.Service;
using Workshop_Razor.Repository;
using AutoMapper;

namespace Workshop_Razor.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
           (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            // Add Services
            services.AddScoped<TourService>();
            services.AddScoped<TourRepository>();
            // Add AutoMapper
            //services.AddAutoMapper(typeof(Program).Assembly);
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}


