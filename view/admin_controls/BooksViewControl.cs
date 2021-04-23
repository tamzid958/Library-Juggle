using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Juggle.controller;

namespace Library_Juggle.view.admin_controls
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
