using System.Collections.Generic;
using System.Windows.Forms;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Data_Access_Layer.Entities;

namespace Library_Juggle.Presentation_Layer.Admin_Controls
{
    public partial class BooksViewControl : UserControl
    {
        private readonly List<Book> _books;
        public BooksViewControl()
        {
            InitializeComponent();
            var book = new BookDataAccess();
            _books = book.GetAllBooks();
            InitState();
        }

        private void InitState()
        {
            BookGridView.DataSource = _books;
        }
    }
}
