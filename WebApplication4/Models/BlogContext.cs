using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models
{
    public class BlogContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    Name = "Food Blog",
                    URL = "https://www.myfood.eat"
                }
            );
        }
        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
                optionsBuilder.UseSqlite("Data Source=blog.db");
               
        }
    }
}
