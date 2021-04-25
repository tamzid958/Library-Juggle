using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Juggle.Business_Logic_Layer;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Data_Access_Layer.Entities;
using MetroFramework;

namespace Library_Juggle.Presentation_Layer.Student_Controls
{
    public partial class BorrowBookControl : UserControl
    {
        private readonly LoanDataAccess _loan;
        private readonly UserDataAccess _user;
        private readonly List<Book> _books;
        public BorrowBookControl()
        {
            InitializeComponent();
            _loan = new LoanDataAccess();
            _user = new UserDataAccess();
            var book = new BookDataAccess();
            _books = book.GetAllBooks();
            InitState();
        }

        private void InitState()
        {
            BookComboBox.Items.Add("Select Book From List");
            BookComboBox.SelectedIndex = 0;

            ReturnedDaysComboBox.SelectedIndex = 0;
            
            foreach (var book in _books) BookComboBox.Items.Add(new KeyValuePair<int, string>(book.BookId, book.BookTitle));
        }

        private void TakeLoanBookButton_Click(object sender, EventArgs e)
        {
            ErrorData.Items.Clear();
            if ( BookComboBox.SelectedIndex == 0 || ReturnedDaysComboBox.SelectedIndex == 0)
            {
                ErrorData.Items.Add("Choose Book and Loan Days");
                return;
            }

            var userId = _user.CurrentUser().UserId;
            var dateIssued = DateTime.Now;
            var (bookId, bookName) = StaticMethods.CastFromObjectToKeyValuePair<int, string>(BookComboBox.SelectedItem);
            var returningDays = int.Parse(ReturnedDaysComboBox.SelectedItem.ToString()?.Replace("Days", "").Replace("Day", "")!);
            var newLoan = new Loan
            {
                BooksBookId = bookId,
                UsersUserId = userId,
                DateIssued = dateIssued,
                ReturningDays = returningDays,
                Returned = false
            };
            if (newLoan.GetModelErrors() == null)
            {
                _loan.CreateLoan(newLoan);
                try
                {
                    MetroMessageBox.Show(this, $@"{bookName} Book Loaned!", @"Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }
            else
            {
                foreach (var errors in newLoan.GetModelErrors()) ErrorData.Items.Add(errors.ErrorMessage!);
            }
        }
    }
}
