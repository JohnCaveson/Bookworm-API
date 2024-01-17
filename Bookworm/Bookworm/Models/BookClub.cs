using Bookworm.DTOs;

namespace Bookworm.Models
{
    public class BookClub
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Poll Poll { get; set; }
        public Book CurrentBook { get; set; }
        public List<Member> Members { get; set; }
    }
}
