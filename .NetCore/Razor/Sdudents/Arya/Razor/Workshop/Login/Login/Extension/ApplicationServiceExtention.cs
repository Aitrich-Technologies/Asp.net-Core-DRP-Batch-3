using AutoMapper;
using Login.Helper;
using Login.Interfacce;
using Login.Model;
using Login.Repository;
using Login.Service;
using Microsoft.EntityFrameworkCore;

namespace Login.Extension
{
    public static class ApplicationServiceExtention
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services,
            IConfiguration config)
        {
            // DbContext
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    config.GetConnectionString("DefaultConnection")));

            // AutoMapper
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            // Repository
            services.AddScoped<IUserRepository, UserRepository>();

            // Service
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}