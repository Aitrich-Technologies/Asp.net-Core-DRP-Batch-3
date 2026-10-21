using Domain.Models;
using Domain.Services;
using Domain.Services.Destinations;
using Domain.Services.Destinations.Interface;
using Domain.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Domain.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services,
            IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    config.GetConnectionString("DefaultConnection")));

            // Repository
            services.AddScoped<IUserRepository, UserRepository>();

            // Service
            services.AddScoped<IUserService, UserService>();

            services.AddScoped<IDestinationService, DestinationService>();
            services.AddScoped<IDestinationRepository, DestinationRepository>();
            return services;
        }
    }
}