using System.Collections.Generic;
using System.Linq;
using Library_Juggle.Business_Logic_Layer;
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
            return _db.Loans.ToList();
        }
        public Loan GetLoan(int loanId)
        {
            return _db.Loans.FirstOrDefault(l=>l.LoanId == loanId);
        }
        public List<LoanModelRepository> GetLoanModelRepository()
        {
            return _db.Loans.Include(u => u.UsersUser)
                .Include(b => b.BooksBook).ToList()
                .Select(loan => new LoanModelRepository
                {
                    LoanId = loan.LoanId,
                    BookName = loan.BooksBook.BookTitle, 
                    UserName = loan.UsersUser.Name, 
                    DateIssued = loan.DateIssued,
                    ReturnDate = loan.DateIssued.AddDays(loan.ReturningDays),
                    Returned = loan.Returned ? "Yes" : "No"
                }).ToList();
        }

        public void CreateLoan(Loan loan)
        {
            _db.Loans.AddAsync(loan);
            _db.SaveChangesAsync();
        }

        public void MarkAsReturned(int loanId)
        {
            var currentLoan = GetLoan(loanId);
            currentLoan.Returned = true;
            _db.Update(currentLoan);
            _db.SaveChangesAsync();
        }
    }
}