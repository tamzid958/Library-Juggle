using System.Collections.Generic;
using System.Linq;
using Library_Juggle.Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library_Juggle.Data_Access_Layer
{
    public class LoanDataAccess
    {
        private readonly LibraryJuggleDbContext _db;

        public LoanDataAccess()
        {
            _db = new LibraryJuggleDbContext();
        }

        public List<Loan> GetAllLoans()
        {
            return _db.Loans.Include(b => b.BooksBook).Include(u=> u.UsersUser).ToList();
        }

        public void CreateLoan(Loan loan)
        {
            _db.Loans.AddAsync(loan);
            _db.SaveChangesAsync();
        }
    }
}