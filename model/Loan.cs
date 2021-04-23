using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Juggle.model
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
