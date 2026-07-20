using BlazorWorkshop2.Helper;
using BlazorWorkshop2.Interface;
using BlazorWorkshop2.Model;
using BlazorWorkshop2.Repository;
using BlazorWorkshop2.Service;
using Microsoft.EntityFrameworkCore;

namespace BlazorWorkshop2.Extension
{
    public static class ApplicationServiceExtension
    {
        public static object AddApplicationService(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IDestinationRepository, DestinationRepository>();
            services.AddScoped<IDestinationService, DestinationService>();
            services.AddScoped<ITourRepository, TourRepository>();

            services.AddScoped<ITourService, TourService>();

            services.AddAutoMapper(cfg => { }, typeof(AutoMapperProfile).Assembly);

            return services;
        }
    }
}
