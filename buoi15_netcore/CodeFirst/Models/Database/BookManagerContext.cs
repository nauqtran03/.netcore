using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Models.Database
{
    public class BookManagerContext : DbContext
    {
        public BookManagerContext(DbContextOptions<BookManagerContext> options):base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}
