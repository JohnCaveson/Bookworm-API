using Bookworm.DTOs;
using Bookworm.Models;
using DbContexts;

namespace Bookworm.Repository
{
    public class BookClubRepository(BookClubDbContext dbContext) : IBookClubRepository
    {
        public async Task<BookClubResponse> Create(BookClubRequest request)
        {
            var response = new BookClubResponse
            {
                BookClubName = request.BookClubName,
                Members = request.Members
            };
            await dbContext.BookClubs.AddAsync(new BookClub
            {
                Name = request.BookClubName,
            });
            foreach (var member in request.Members)
            {
                await dbContext.Members.AddAsync(new Member
                {
                    UserId = member.UserId,
                    Username = member.Username
                });
            }
            return await Task.FromResult(response);
        }
    }
}
