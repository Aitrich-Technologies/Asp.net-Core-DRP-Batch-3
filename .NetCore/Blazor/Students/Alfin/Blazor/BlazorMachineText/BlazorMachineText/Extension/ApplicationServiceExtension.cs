using BlazorMachineText.Helper;
using BlazorMachineText.Interface;
using BlazorMachineText.Model;
using BlazorMachineText.Repository;
using BlazorMachineText.Service;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace BlazorMachineText.Extension
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
            services.AddScoped<IUserSevice, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
