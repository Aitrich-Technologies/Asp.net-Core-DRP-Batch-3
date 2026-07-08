using Blazor_Authentication_Sample.Data;
using Blazor_Authentication_Sample.Interface;
using Blazor_Authentication_Sample.Repository;
using Blazor_Authentication_Sample.Service;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Authentication_Sample.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
          (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
