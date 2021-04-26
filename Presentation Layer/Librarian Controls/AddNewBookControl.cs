using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Library_Juggle.Business_Logic_Layer;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Data_Access_Layer.Entities;
using MetroFramework;

namespace Library_Juggle.Presentation_Layer.Librarian_Controls
{
    public partial class AddNewBookControl : UserControl
    {
        private readonly BookDataAccess _book;
        private readonly List<Genre> _genres;

        public AddNewBookControl()
        {
            InitializeComponent();
            _book = new BookDataAccess();
            var genre = new GenreDataAccess();
            _genres = genre.GetAllGenres();
            InitState();
        }

        private void InitState()
        {
            BookGenre.Items.Add("Select Genre From List");
            BookGenre.SelectedIndex = 0;
            foreach (var genre in _genres)
                BookGenre.Items.Add(new KeyValuePair<int, string>(genre.GenreId, genre.GenreName));
        }

        private void AddNewBookButton_Click(object sender, EventArgs e)
        {
            ErrorData.Items.Clear();
            if (BookGenre.SelectedIndex == 0)
            {
                ErrorData.Items.Add("Choose Book Genre");
                return;
            }

            var bookTitle = BookTitle.Text;
            var bookAuthor = BookAuthor.Text;
            var bookPublisher = BookPublisher.Text;
            var bookPublishDate = BookPublishDate.Text;
            var genreId = BookGenre.SelectedItem.CastFromObjectToKeyValuePair<int, string>().Key;

            var newBook = new Book
            {
                BookTitle = bookTitle,
                BookAuthor = bookAuthor,
                BookPublisher = bookPublisher,
                BookPublishedDate = bookPublishDate,
                GenreId = genreId
            };
            if (newBook.GetModelErrors() == null)
            {
                _book.CreateBook(newBook);
                try
                {
                    MetroMessageBox.Show(this, @"New Book Added!", @"Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }
            else
            {
                foreach (var errors in newBook.GetModelErrors()) ErrorData.Items.Add(errors.ErrorMessage!);
            }
        }
    }
}