using Domain.Helper;
using Domain.Models;
using Domain.Services.Destinations;
using Domain.Services.Destinations.Interface;
using Domain.Services.User;
using Domain.Services.User.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Extension
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<TourBookingDbContext>(options =>
               options.UseSqlServer(config.GetConnectionString("DefaultConnection"))
            );
            services.AddAutoMapper(cfg => { }, typeof(MappingProfile));

            services.AddScoped<IDestinationService, DestinationService>();
            services.AddScoped<IDestinationRepository, DestinationRepository>();


            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();


            return services;
        }
    }
}
