using Bookworm.Models;
using Microsoft.EntityFrameworkCore;
namespace DbContexts
{
    public class BookClubDbContext : DbContext
    {
        public BookClubDbContext(DbContextOptions options) : base(options) { }
        public DbSet<BookClub> BookClubs { get; set; } = null;
    }
}
