using MachineTest.Interface;
using MachineTest.Model;
using MachineTest.Repository;
using MachineTest.Services;
using Microsoft.EntityFrameworkCore;

namespace MachineTest.Extension
{
    public static class ServiceExtension
    {
        public static IServiceCollection AddProjectServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IStudentRepository, StudentRepository>();

            services.AddScoped<IStudentService, StudentService>();
            return services;


        }
}
}
