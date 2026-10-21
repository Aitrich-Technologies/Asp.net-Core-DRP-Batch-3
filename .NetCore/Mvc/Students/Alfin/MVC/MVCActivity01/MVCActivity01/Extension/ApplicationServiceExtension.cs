
using Microsoft.EntityFrameworkCore;
using MVCActivity01.Helper;
using MVCActivity01.Interface;
using MVCActivity01.Models;
using MVCActivity01.Repository;
using MVCActivity01.Service;

namespace MVCActivity01.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(Options =>
        Options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(cfg => { }, typeof(MappingProfile).Assembly);
            //services.AddAutoMapper (typeof(MappingProfile));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            return services;
                }
    }
}
