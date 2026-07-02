using Microsoft.EntityFrameworkCore;
using Workshop_Razor.Models;
using Workshop_Razor.Helper;
using Workshop_Razor.Service;
using Workshop_Razor.Extension;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddApplicationServices(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.MapFallbackToPage("/Tour/Index");

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
