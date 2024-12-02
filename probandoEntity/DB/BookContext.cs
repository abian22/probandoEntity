using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options) 
        { 
        
        }
        public DbSet<User> Users { get; set; } 
    }
}
