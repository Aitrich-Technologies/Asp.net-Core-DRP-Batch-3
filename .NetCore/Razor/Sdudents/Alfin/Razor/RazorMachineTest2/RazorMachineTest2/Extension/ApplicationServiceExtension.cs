
using Microsoft.EntityFrameworkCore;
using RazorMachineTest2.Helper;
using RazorMachineTest2.Interface;
using RazorMachineTest2.Models;
using RazorMachineTest2.Repository;
using RazorMachineTest2.Service;
using AutoMapper;

namespace RazorMachineTest2.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"))

            );
            services.AddAutoMapper(cfg => cfg.AddProfile<MappingProfile>());

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IVehicleRepository, VehicleRepository>();
            services.AddScoped<IVehicleService, VehicleService>();




            //services.AddScoped<UserRepository>();
            //services.AddScoped<VehicleRepository>();

            return services;
        }
    }
}
