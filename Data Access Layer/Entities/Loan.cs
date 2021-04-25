using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Library_Juggle.Data_Access_Layer.Entities
{
    public class Loan
    {
        [Key] public int LoanId { get; set; }

        [Required] public DateTime DateIssued { get; set; }

        [Required] public int ReturningDays { get; set; }

        [Required] public bool Returned { get; set; }
        
        [Required] [ForeignKey("User")] public int UsersUserId { get; set; }

        [Required] [ForeignKey("Book")] public int BooksBookId { get; set; }

        public virtual Book BooksBook { get; set; }
        public virtual User UsersUser { get; set; }
    }
}