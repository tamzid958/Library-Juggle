using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Juggle.model
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
