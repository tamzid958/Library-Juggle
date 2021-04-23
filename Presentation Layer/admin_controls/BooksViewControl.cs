using System.Windows.Forms;
using Library_Juggle.Data_Access_Layer;

namespace Library_Juggle.Presentation_Layer.admin_controls
{
    public partial class BooksViewControl : UserControl
    {
        private readonly BookController _book;
        public BooksViewControl()
        {
            InitializeComponent();
            _book = new BookController();
            InitState();
        }

        private void InitState()
        {
            BookGridView.DataSource = _book.GetAllBooks();
        }
    }
}
