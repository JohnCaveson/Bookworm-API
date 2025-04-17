using Bookworm.Models;
using Microsoft.EntityFrameworkCore;
namespace DbContexts
{
    public class BookClubDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<BookClub> BookClubs { get; set; } = null;
        public DbSet<Member> Members { get; set; } = null;
    }
}
