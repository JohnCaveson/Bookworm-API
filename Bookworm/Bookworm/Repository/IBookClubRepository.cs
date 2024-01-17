using Bookworm.DTOs;

namespace Bookworm.Repository
{
    public interface IBookClubRepository
    {
        Task<BookClubDTO> Create(BookClubDTO dto);
    }
}
