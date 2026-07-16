using Workshop.Components;
using Workshop.Extension;

namespace Workshop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            // Register application services
            builder.Services.AddApplicationServices(builder.Configuration);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            // Custom error page for status codes (404, etc.)
            app.UseStatusCodePagesWithReExecute(
                "/not-found",
                createScopeForStatusCodePages: true);

            app.UseHttpsRedirection();

            // Enable static files (wwwroot)
            app.UseStaticFiles();

            // Enable Session
            app.UseSession();

            // Enable antiforgery protection
            app.UseAntiforgery();

            // Map static assets
            app.MapStaticAssets();

            // Map Razor Components
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}