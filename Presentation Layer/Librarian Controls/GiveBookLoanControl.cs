using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Library_Juggle.Business_Logic_Layer;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Data_Access_Layer.Entities;
using MetroFramework;

namespace Library_Juggle.Presentation_Layer.Librarian_Controls
{
    public partial class GiveBookLoanControl : UserControl
    {
        private readonly List<Book> _books;
        private readonly LoanDataAccess _loan;
        private readonly List<User> _users;

        public GiveBookLoanControl()
        {
            InitializeComponent();
            _loan = new LoanDataAccess();
            var user = new UserDataAccess();
            var book = new BookDataAccess();
            _users = user.GetAllUsers();
            _books = book.GetAllBooks();
            InitState();
        }

        private void InitState()
        {
            UserComboBox.Items.Add("Select User From List");
            UserComboBox.SelectedIndex = 0;

            BookComboBox.Items.Add("Select Book From List");
            BookComboBox.SelectedIndex = 0;

            ReturnedDaysComboBox.SelectedIndex = 0;

            foreach (var user in _users) UserComboBox.Items.Add(new KeyValuePair<int, string>(user.UserId, user.Name));
            foreach (var book in _books)
                BookComboBox.Items.Add(new KeyValuePair<int, string>(book.BookId, book.BookTitle));
        }

        private void GiveLoanBookButton_Click(object sender, EventArgs e)
        {
            ErrorData.Items.Clear();
            if (UserComboBox.SelectedIndex == 0 || BookComboBox.SelectedIndex == 0 ||
                ReturnedDaysComboBox.SelectedIndex == 0)
            {
                ErrorData.Items.Add("Choose Book, User and Loan Days");
                return;
            }

            var (bookId, bookName) = StaticMethods.CastFromObjectToKeyValuePair<int, string>(BookComboBox.SelectedItem);
            var (userId, userName) = StaticMethods.CastFromObjectToKeyValuePair<int, string>(UserComboBox.SelectedItem);
            var dateIssued = DateTime.Parse(LoanDate.Text);
            var returningDays =
                int.Parse(ReturnedDaysComboBox.SelectedItem.ToString()?.Replace("Days", "").Replace("Day", "")!);
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
                    MetroMessageBox.Show(this, $@"{bookName} Book Loaned To {userName}!", @"Information",
                        MessageBoxButtons.OK,
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