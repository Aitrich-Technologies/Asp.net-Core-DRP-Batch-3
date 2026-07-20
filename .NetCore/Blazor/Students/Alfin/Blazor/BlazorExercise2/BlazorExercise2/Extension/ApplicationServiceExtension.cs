using BlazorExercise2.Helper;
using BlazorExercise2.Interface;
using BlazorExercise2.Model;
using BlazorExercise2.Repository;
using BlazorExercise2.Service;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;


namespace BlazorExercise2.Extension
{
    public static class ApplicationServiceExtension
    {

        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddScoped<ProtectedSessionStorage>();
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddAutoMapper(cfg => { }, typeof(MappingProfile));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IDestRepository, DestRepository>();
            services.AddScoped<IDestService, DestService>();
            return services;
        }

    }
}
