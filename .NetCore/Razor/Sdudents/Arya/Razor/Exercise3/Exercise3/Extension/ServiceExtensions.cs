using Exercise3.Helper;
using Exercise3.Interface;
using Exercise3.Models;
using Exercise3.Repository;
using Exercise3.Service;
using Microsoft.EntityFrameworkCore;

namespace Exercise3.Extension
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection services, IConfiguration configuration)



        {
            // DbContext
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();

            /// Add AutoMapper
            services.AddAutoMapper(cfg => cfg.AddProfile<UsingMappingProfile>());
        //OR: services.AddAutoMapper(typeof(MappingProfile).Assembly);

            return services;

        }
    }
}