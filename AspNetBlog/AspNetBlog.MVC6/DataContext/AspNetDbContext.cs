using AspNetBlog.MVC6.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetBlog.MVC6.DataContext
{
    public class AspNetDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-K0JNG2Q\SQLEXPRESS;Database=AspNetPostDB;User Id=sa;Password=dbsguswns1;");
        }
    }
}
