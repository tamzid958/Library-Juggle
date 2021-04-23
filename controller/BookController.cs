using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_Juggle.data;
using Library_Juggle.model;

namespace Library_Juggle.controller
{
    public class BookController
    {
        private readonly LibraryJuggleContext _db;

        public BookController()
        {
            _db = new LibraryJuggleContext();
        }

        public List<Book> GetAllBooks()
        {
            return _db.Books.ToList();
        }
    }
}
