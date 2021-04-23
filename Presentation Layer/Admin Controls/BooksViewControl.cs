using System.Windows.Forms;
using Library_Juggle.Data_Access_Layer;

namespace Library_Juggle.Presentation_Layer.Admin_Controls
{
    public partial class BooksViewControl : UserControl
    {
        private readonly BookDataAccess _book;
        public BooksViewControl()
        {
            InitializeComponent();
            _book = new BookDataAccess();
            InitState();
        }

        private void InitState()
        {
            BookGridView.DataSource = _book.GetAllBooks();
        }
    }
}
