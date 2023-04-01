using Microsoft.EntityFrameworkCore;

namespace ForPractice.Model
{
    public class BookNetDBContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Chapter> Chapters { get; set; }

        public BookNetDBContext(DbContextOptions<BookNetDBContext> options) : base(options)
        {

        }
    }
}
