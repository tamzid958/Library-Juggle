using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Library_Juggle.Business_Logic_Layer;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Data_Access_Layer.Entities;
using MetroFramework;

namespace Library_Juggle.Presentation_Layer.Shared_Controls
{
    public partial class BooksViewControl : UserControl
    {
        private readonly BookDataAccess _book;
        private readonly List<Genre> _genres;
        private readonly UserDataAccess _user;

        public BooksViewControl()
        {
            InitializeComponent();
            _book = new BookDataAccess();
            _user = new UserDataAccess();
            var genre = new GenreDataAccess();
            _genres = genre.GetAllGenres();
            InitState();
        }

        private void InitState(string bookTitle = null)
        {
            BookGridView.DataSource = null;
            var genreComboBoxColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = @"Genre",
                Name = @"UserDataGridGenre",
                DataPropertyName = @"GenreId",
                DataSource = _genres,
                DisplayMember = @"GenreName",
                ValueMember = @"GenreId",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            var deleteButtonsColumn = new DataGridViewButtonColumn
            {
                HeaderText = @"Delete",
                Name = @"UserDataGridBookDelete",
                DataPropertyName = @"BookId",
                UseColumnTextForButtonValue = true,
                Text = @"Delete",
                FlatStyle = FlatStyle.Flat
            };
            BookGridView.DataSource = _book.GetAllBooksByName(bookTitle);
            BookGridView.Columns[0].Visible = BookGridView.Columns[5].Visible =
                BookGridView.Columns[6].Visible = BookGridView.Columns[7].Visible = false;
            BookGridView.Columns[1].HeaderText = @"Title";
            BookGridView.Columns[2].HeaderText = @"Author";
            BookGridView.Columns[3].HeaderText = @"Publisher";
            BookGridView.Columns[4].HeaderText = @"Publish Date";
            var checkUserPermission = _user.CurrentUser().Role.RoleName;
            if (checkUserPermission is "Admin" or "Librarian")
            {
                BookGridView.Columns.AddRange(genreComboBoxColumn, deleteButtonsColumn);
            }
            else
            {
                BookGridView.Columns.Add(genreComboBoxColumn);
                BookGridView.ReadOnly = true;
            }
        }

        private void SearchBookTerm_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchBookTerm.Text)) return;
            InitState(SearchBookTerm.Text);
        }

        private void BookGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (BookGridView.CurrentRow == null) return;
            var bookId = int.Parse(StaticMethods.GridViewDataAccess(BookGridView, "BookId"));
            var bookTitle = StaticMethods.GridViewDataAccess(BookGridView, "BookTitle");
            var bookAuthor = StaticMethods.GridViewDataAccess(BookGridView, "BookAuthor");
            var bookPublisher = StaticMethods.GridViewDataAccess(BookGridView, "BookPublisher");
            var bookPublishDate = StaticMethods.GridViewDataAccess(BookGridView, "BookPublishedDate");
            var genreId = int.Parse(StaticMethods.GridViewDataAccess(BookGridView, "UserDataGridGenre"));
            var currentBook = _book.GetBook(bookId);
            if (currentBook == null
                || string.IsNullOrWhiteSpace(bookTitle)
                || string.IsNullOrWhiteSpace(bookAuthor)
                || string.IsNullOrWhiteSpace(bookPublisher)
                || string.IsNullOrWhiteSpace(bookPublishDate)) return;
            _book.UpdateBook(bookId, bookTitle, bookAuthor, bookPublisher, bookPublishDate, genreId);
            try
            {
                MetroMessageBox.Show(this, $"{bookTitle} Updated!", @"Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        private void BookGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 9 || BookGridView.CurrentRow == null) return;
            var bookId = int.Parse(StaticMethods.GridViewDataAccess(BookGridView, "BookId"));
            try
            {
                _book.DeleteBook(bookId);
                MetroMessageBox.Show(this, @"Book Deleted!", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            InitState();
        }
    }
}