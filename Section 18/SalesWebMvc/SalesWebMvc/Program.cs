﻿using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Services;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

namespace SalesWebMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            string mySqlConnection = builder.Configuration.GetConnectionString("SalesWebMvcContext");

            builder.Services.AddDbContext<SalesWebMvcContext>(options =>
                           options.UseMySql(mySqlConnection,
                           ServerVersion.AutoDetect(mySqlConnection)));

            builder.Services.AddScoped<SeedingService>();
            builder.Services.AddScoped<SellerService>();
            builder.Services.AddScoped<DepartmentService>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            
            var enUs = new CultureInfo("en-US");
            
            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(enUs),
                SupportedCultures = new[] { enUs },
                SupportedUICultures = new[] { enUs }
            };

            app.UseRequestLocalization(localizationOptions); 

            // Retrieve an instance of SeedingService from the service provider.
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var seedingService = services.GetRequiredService<SeedingService>();

                // Seed the database.
                seedingService.Seed();
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}