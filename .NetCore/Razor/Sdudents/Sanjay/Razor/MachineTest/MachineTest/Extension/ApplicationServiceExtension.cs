namespace MachineTest.Extension;
using AutoMapper;
using MachineTest.Interface;
using MachineTest.Helper;
using MachineTest.Models;
using Microsoft.EntityFrameworkCore;
using MachineTest.Helper;
using MachineTest.Models;
using MachineTest.Repository;
using MachineTest.Service;
public static class ApplicationServiceExtension
{
        public static IServiceCollection AddApplicationServices
           (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUserRepository,  UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPackageService, PackageService>();
        services.AddScoped<IPackageRepository, PackageRepository>();
        services.AddScoped<PackageRepository>();
        services.AddScoped<PackageService>();

        services.AddAutoMapper(cfg => { }, typeof(AutoMapperProfile).Assembly);

        return services;
        }
    }

