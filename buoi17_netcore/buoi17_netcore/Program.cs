using buoi17_netcore.Models.DBModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace buoi17_netcore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var connectStr = builder.Configuration.GetConnectionString("DBConnect");
            builder.Services.AddDbContext<DatabaseFirstContext>(otp => otp.UseSqlServer(connectStr));

            //Cau hinh session
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(otp =>
            {
                otp.IdleTimeout = TimeSpan.FromMinutes(60);
                otp.Cookie.HttpOnly = true;
                otp.Cookie.IsEssential = true;
                otp.Cookie.Name = ".QuangQuan.Session";
            });

            var app = builder.Build();

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

            app.UseSession();

            app.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
