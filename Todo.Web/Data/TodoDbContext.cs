using Microsoft.EntityFrameworkCore;

namespace Todo.Web.Data
{
    public class TodoDbContext(DbContextOptions<TodoDbContext> dbContextOptions) : DbContext(dbContextOptions)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
