using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        { 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().ToTable("TodoItems");
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
