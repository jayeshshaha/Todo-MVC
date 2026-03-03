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
