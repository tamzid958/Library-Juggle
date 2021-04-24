using System.Collections.Generic;
using System.Windows.Forms;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Data_Access_Layer.Entities;

namespace Library_Juggle.Presentation_Layer.Admin_Controls
{
    public partial class BooksViewControl : UserControl
    {
        private readonly BookDataAccess _book;
        private readonly UserDataAccess _user;
        private readonly List<User> _users;
        private readonly List<Book> _books;
        public BooksViewControl()
        {
            InitializeComponent();
            _book = new BookDataAccess();
            _user = new UserDataAccess();

            _books = _book.GetAllBooks();
            InitState();
        }

        private void InitState()
        {
            BookGridView.DataSource = _books;
        }
    }
}
