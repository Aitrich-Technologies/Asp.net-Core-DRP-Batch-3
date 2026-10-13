using MachineTest.Helper;
using MachineTest.Interface;
using MachineTest.Models;
using MachineTest.Repository;
using MachineTest.Services;
using Microsoft.EntityFrameworkCore;

namespace MachineTest.Extension
{
    public static class ApplicationServiceExtension 
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );


            services.AddAutoMapper(cfg => { }, typeof(MappingProfile));
            
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService,UserService>();

            services.AddScoped<ITourRepository, TourRepository>();
            services.AddScoped<ITourService, TourService>();

            return services;
        }
    }
}
