using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Data_Access_Layer.Entities;

namespace Library_Juggle.Presentation_Layer.Shared_Controls
{
    public partial class LoansViewControl : UserControl
    {
        private readonly List<Book> _books;
        private readonly List<User> _users;
        private readonly List<Loan> _loans;
        public LoansViewControl()
        {
            InitializeComponent();
            var loan = new LoanDataAccess();
            var book = new BookDataAccess();
            var user = new UserDataAccess();
            _books = book.GetAllBooks();
            _users = user.GetAllUsers();
            _loans = loan.GetAllLoans();
            InitState();
        }

        private void InitState()
        {
            ArrayList comboBoxList = new()
            {
              new DataGridViewComboBoxColumn{
                    HeaderText = @"Book",
                    Name = @"UserDataGridBook",
                    DataPropertyName = @"BookId",
                    DataSource = _books,
                    DisplayMember = @"BookTitle",
                    ValueMember = @"BookId",
                    DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
                },
              new DataGridViewComboBoxColumn
              {
                  HeaderText = @"User",
                  Name = @"UserDataGridUser",
                  DataPropertyName = @"UserId",
                  DataSource = _users,
                  DisplayMember = @"Name",
                  ValueMember = @"UserId",
                  DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
              }
            };
            
            LoanGridView.Columns.AddRange((DataGridViewColumn[]) comboBoxList.ToArray(typeof(DataGridViewColumn)));
            LoanGridView.DataSource = _loans;
            LoanGridView.Columns[2].Visible = LoanGridView.Columns[4].Visible = LoanGridView.Columns[5].Visible =
                LoanGridView.Columns[6].Visible = LoanGridView.Columns[7].Visible = false;
           LoanGridView.Columns[3].HeaderText = @"Issue Date";
        }
    }
}
