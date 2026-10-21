using Microsoft.EntityFrameworkCore;
using MVCActivity02.Models;
using System.Runtime.CompilerServices;

namespace MVCActivity02.Extension
{
    public static class ApplicationServiceExtension 
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(Options =>
            Options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            return services;
        }
    }
}
