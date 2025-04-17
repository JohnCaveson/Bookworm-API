using Bookworm.DTOs;

namespace Bookworm.Repository
{
    public interface IBookClubRepository
    {
        Task<BookClubResponse> Create(BookClubRequest request);
    }
}
