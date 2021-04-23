using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Juggle.model
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
