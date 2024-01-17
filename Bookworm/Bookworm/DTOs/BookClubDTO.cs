namespace Bookworm.DTOs
{
    public class BookClubDTO
    {
        public string BookClubName { get; set; }
        public PollDTO Poll { get; set; }
        public BookDTO CurrentBook { get; set; }
        public List<MemberDTO> Members { get; set; }
    }
}
