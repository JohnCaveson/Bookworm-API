namespace Bookworm.DTOs
{
    public record struct BookClubRequest
    {
        public string BookClubName { get; init; }
        public List<MemberDTO> Members { get; init; }
    }
    public class BookClubResponse
    {
        public string BookClubName { get; set; }
        public PollDTO? Poll { get; set; }
        public BookDTO? CurrentBook { get; set; }
        public List<MemberDTO> Members { get; set; }
    }
}
