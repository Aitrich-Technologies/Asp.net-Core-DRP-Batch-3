using AutoMapper;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using Workshop.Helper;
using Workshop.Interface;
using Workshop.Models;
using Workshop.Repository;
using Workshop.Service;

namespace Workshop.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services,
            IConfiguration config)
        {
            // Session Storage
            services.AddScoped<ProtectedSessionStorage>();

            // Database Connection
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    config.GetConnectionString("DefaultConnection")));

            // Session Configuration
            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            // AutoMapper Configuration
            services.AddAutoMapper(cfg => { }, typeof(MappingProfile));

            

           

            // Dependency Injection
            services.AddScoped<IDestinationRepository, DestinationRepository>();
            services.AddScoped<IDestinationService, DestinationService>();

            return services;
        }
    }
}