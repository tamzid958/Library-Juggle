using System.ComponentModel.DataAnnotations;

namespace Library_Juggle.Data_Access_Layer.Entities
{
    public class Book
    {
        [Key]
        public int BookId { set; get; }

        [Required]
        public string BookTitle { set; get; }

        [Required]
        public string BookAuthor { set; get; }

        [Required]
        public string BookPublisher { set; get; }

        [Required]
        public string BookPublishedDate { set; get; }

        [Required]
        public int GenreId { set; get; }

        [Required]
        public int BookUserId { set; get; }

        public virtual User Users { set; get; }
        public virtual Genre Genre { set; get; }
    }
}
