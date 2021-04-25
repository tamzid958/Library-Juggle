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

        public Book GetBook(int bookId)
        {
            return _db.Books.FirstOrDefault(b => b.BookId == bookId);
        }

        public List<Book> GetAllBooksByName(string bookTitle)
        {
            return string.IsNullOrWhiteSpace(bookTitle)
                ? GetAllBooks()
                : _db.Books.Where(b => b.BookTitle.ToLower().Contains(bookTitle.ToLower())).ToList();
        }

        public void CreateBook(Book book)
        {
            _db.Books.AddAsync(book);
            _db.SaveChangesAsync();
        }

        public void UpdateBook(int bookId, string bookTitle, string bookAuthor, string bookPublisher,
            string bookPublishDate, int genreId)
        {
            var currentBook = GetBook(bookId);
            currentBook.BookTitle = bookTitle;
            currentBook.BookAuthor = bookAuthor;
            currentBook.BookPublisher = bookPublisher;
            currentBook.BookPublishedDate = bookPublishDate;
            currentBook.GenreId = genreId;
            _db.Books.Update(currentBook);
            _db.SaveChangesAsync();
        }

        public void DeleteBook(int bookId)
        {
            _db.Books.Remove(GetBook(bookId));
            _db.SaveChangesAsync();
        }
    }
}