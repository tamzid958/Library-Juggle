using System.Collections.Generic;
using System.Linq;
using Library_Juggle.Data_Access_Layer.Entities;

namespace Library_Juggle.Data_Access_Layer
{
    public class BookDataAccess
    {
        private readonly LibraryJuggleDbContext _db;

        public BookDataAccess()
        {
            _db = new LibraryJuggleDbContext();
        }

        public List<Book> GetAllBooks()
        {
            return _db.Books.ToList();
        }
    }
}