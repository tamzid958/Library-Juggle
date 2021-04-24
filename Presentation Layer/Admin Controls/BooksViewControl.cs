using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Data_Access_Layer.Entities;

namespace Library_Juggle.Presentation_Layer.Admin_Controls
{
    public partial class BooksViewControl : UserControl
    {
        private readonly BookDataAccess _book;
        private readonly List<Genre> _genres;

        public BooksViewControl()
        {
            InitializeComponent();
            _book = new BookDataAccess();
            var genre = new GenreDataAccess();
            _genres = genre.GetAllGenres();
            InitState();
        }

        private void InitState(string bookTitle = null)
        {
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

            BookGridView.DataSource = _book.GetAllBooksByName(bookTitle);
            BookGridView.Columns[0].Visible = BookGridView.Columns[5].Visible =
                BookGridView.Columns[6].Visible = BookGridView.Columns[7].Visible = false;
            BookGridView.Columns[1].HeaderText = @"Title";
            BookGridView.Columns[2].HeaderText = @"Author";
            BookGridView.Columns[3].HeaderText = @"Publisher";
            BookGridView.Columns[4].HeaderText = @"Published Date";
            BookGridView.Columns.Add(genreComboBoxColumn);
        }

        private void SearchBookTerm_KeyUp(object sender, KeyEventArgs e)
        {
            BookGridView.DataSource = null;
            InitState(SearchBookTerm.Text);
        }
    }
}