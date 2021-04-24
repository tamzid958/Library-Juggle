using System;

#nullable disable

namespace Library_Juggle.Data_Access_Layer.Entities
{
    public class Loan
    {
        public int LoanId { get; set; }
        public DateTime DateIssued { get; set; }
        public int? UsersUserId { get; set; }
        public int? BooksBookId { get; set; }

        public virtual Book BooksBook { get; set; }
        public virtual User UsersUser { get; set; }
    }
}
