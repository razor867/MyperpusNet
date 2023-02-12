using Microsoft.EntityFrameworkCore;
using APP_API.Model;

namespace APP_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<book> book { get; set; }
        public DbSet<category_book> category_book { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<book>().HasKey(k => new { k.book_id });
            builder.Entity<category_book>().HasKey(k => new { k.category_id });
        }
    }
}