using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Todo.Web.Data;

namespace Todo.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<TodoDbContext>(option =>
            {
                option.UseSqlite(builder.Configuration.GetConnectionString("Default"));
            });

            builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireDigit = false;
            })
                .AddEntityFrameworkStores<TodoDbContext>()
                .AddDefaultTokenProviders();

            var app = builder.Build();

            app.UseStaticFiles();
            app.UseRouting();

            app.MapControllerRoute(
                name:"default",
                pattern:"{controller=Todos}/{action=Index}/{id?}"
                );

            app.Run();
        }
    }
}
