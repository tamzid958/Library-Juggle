using System.Collections.Generic;

#nullable disable

namespace Library_Juggle.Data_Access_Layer.Entities
{
    public sealed class Book
    {
        public Book()
        {
            Loans = new HashSet<Loan>();
        }

        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string BookPublisher { get; set; }
        public string BookPublishedDate { get; set; }
        public int GenreId { get; set; }
        public int? UsersUserId { get; set; }

        public Genre Genre { get; set; }
        public User UsersUser { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}
