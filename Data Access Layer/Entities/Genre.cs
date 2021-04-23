using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library_Juggle.Data_Access_Layer.Entities
{
    public class Genre
    {
        public Genre()
        {
            Books = new HashSet<Book>();
        }

        [Key]
        public int GenreId { set; get; }

        [Required]
        [StringLength(70)]
        public string GenreName { set; get; }

        [Required]
        public int GenreUserId { set; get; }

        public virtual User Users { set; get; }
        public ICollection<Book> Books { set; get; }
    }
}
