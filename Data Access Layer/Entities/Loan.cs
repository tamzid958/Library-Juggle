using System;
using System.ComponentModel.DataAnnotations;

namespace Library_Juggle.Data_Access_Layer.Entities
{
    public class Loan
    {
        [Key]
        public int LoanId { set; get; }

        [Required]
        public DateTime DateIssued { set; get; }

        [Required]
        public int LoanBookId { set; get; }

        [Required]
        public int LoanUserId { set; get; }

        public virtual User Users { set; get; }
        public virtual Book Books { set; get; }
    }
}
