using System.Collections.Generic;

#nullable disable

namespace Library_Juggle.Data_Access_Layer.Entities
{
    public sealed class Genre
    {
        public Genre()
        {
            Books = new HashSet<Book>();
        }

        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public int? UsersUserId { get; set; }

        public User UsersUser { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
