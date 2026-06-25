using Exercise.Helper;
using Exercise.Models;
using Exercise.Repository;
using Exercise.Service;
using Microsoft.EntityFrameworkCore;

namespace Exercise.Extension
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices
           (this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(config.GetConnectionString("DefaultConnection")));


            services.AddScoped<ConsultantService>();
            services.AddScoped<ConsultantRepository>();
            services.AddScoped<RegisterService>();
            services.AddScoped<RegisterRepository>();
            services.AddAutoMapper(cfg => { }, typeof(AutoMapperProfile).Assembly);
            return services;
        }
    }
}
