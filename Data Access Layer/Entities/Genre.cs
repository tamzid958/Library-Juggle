using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Library_Juggle.Data_Access_Layer.Entities
{
    public sealed class Genre
    {
        public Genre()
        {
            Books = new HashSet<Book>();
        }
        [Key]
        public int GenreId { get; set; }
        
        [Required]
        public string GenreName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
