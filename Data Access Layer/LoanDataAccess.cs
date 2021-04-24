using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Juggle.Data_Access_Layer.Entities;

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
    }
}
