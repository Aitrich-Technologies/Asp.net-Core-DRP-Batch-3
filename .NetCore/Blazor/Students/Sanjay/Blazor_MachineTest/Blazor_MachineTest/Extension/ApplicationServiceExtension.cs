using Blazor_MachineTest.Helper;
using Blazor_MachineTest.Interface;
using Blazor_MachineTest.Model;
using Blazor_MachineTest.Service;
using Blazor_MachineTest.Repository;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace Blazor_MachineTest.Extension
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
            services.AddScoped<IStudService, StudService>();
            services.AddScoped<IStudRepository, StudRepository>();

            return services;
        }
    }
}
