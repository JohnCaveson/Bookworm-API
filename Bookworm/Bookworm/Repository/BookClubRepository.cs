using Bookworm.DTOs;
using DbContexts;

namespace Bookworm.Repository
{
    public class BookClubRepository : IBookClubRepository
    {
        private readonly BookClubDbContext _dbContext;

        public BookClubRepository(BookClubDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<BookClubDTO> Create(BookClubDTO dto)
        {
            return dto;
        }
    }
}
