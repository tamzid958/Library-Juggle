using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Library_Juggle.Data_Access_Layer.Entities
{
    public sealed class Book
    {
        public Book()
        {
            Loans = new HashSet<Loan>();
        }

        [Key] public int BookId { get; set; }

        [Required] public string BookTitle { get; set; }

        [Required] public string BookAuthor { get; set; }

        [Required] public string BookPublisher { get; set; }

        [Required] public string BookPublishedDate { get; set; }

        [Required] [ForeignKey("Genre")] public int GenreId { get; set; }

        public Genre Genre { get; set; }
        public ICollection<Loan> Loans { get; set; }
    }
}