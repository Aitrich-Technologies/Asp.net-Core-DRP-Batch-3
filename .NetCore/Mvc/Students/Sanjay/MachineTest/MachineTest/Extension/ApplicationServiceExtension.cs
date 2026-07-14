using MachineTest.Helper;
using MachineTest.Interface;
using MachineTest.Models;
using MachineTest.Repository;
using MachineTest.Service;
using Microsoft.EntityFrameworkCore;

namespace MachineTest.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );
            services.AddAutoMapper(cfg => { }, typeof(MappingProfile));

            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IAuthRepository, AuthRepository>();

            services.AddScoped<IDestinationService, DestinationService>();
            services.AddScoped<IDestinationRepository,  DestinationRepository>();




            return services;
        }
    }
}
