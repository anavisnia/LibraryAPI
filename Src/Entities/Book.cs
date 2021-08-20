using LibraryAPI.Entities.Base;

namespace LibraryAPI.Entities
{
    public class Book : Entity
    {
        public Author Author { get; set; }
        public string ISBN { get; set; }
        public int AuthorId { get; set; }
    }
}