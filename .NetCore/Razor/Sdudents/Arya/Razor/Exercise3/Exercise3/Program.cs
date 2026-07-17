using Exercise3.Extension;
using Exercise3.Interface;
using Exercise3.Models;
using Exercise3.Repository;
using Exercise3.Service;
using Microsoft.EntityFrameworkCore;

namespace Exercise3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Services
            builder.Services.AddRazorPages();

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddProjectServices(builder.Configuration);

            // ✅ YOUR SERVICES
            builder.Services.AddScoped<IDestinationService, DestinationService>();
            builder.Services.AddScoped<IDestinationRepository, DestinationRepository>();

            // Session
            builder.Services.AddSession();

            var app = builder.Build();

            // 🔥 IMPORTANT MIDDLEWARE ORDER
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            // ✅ REQUIRED FOR IMAGES
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();   // better placed after routing

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}