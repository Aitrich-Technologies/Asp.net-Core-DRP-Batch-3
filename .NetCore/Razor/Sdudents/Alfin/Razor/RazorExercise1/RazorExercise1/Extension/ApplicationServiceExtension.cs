
using Microsoft.EntityFrameworkCore;
using RazorExercise1.Helper;
using RazorExercise1.Model;
using RazorExercise1.Repository;
using RazorExercise1.Service;

namespace RazorExercise1.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
            (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddScoped<ConsultantService>();
            services.AddScoped<ConsultantRepository>();
            services.AddScoped<RegisterService>();
            services.AddScoped<RegisterRepository>();
            // Add AutoMapper
            services.AddAutoMapper(cfg => { }, typeof(AutoMapperProfile).Assembly);
            return services;
        }
    }
}
