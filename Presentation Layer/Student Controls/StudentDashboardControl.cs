using System;
using System.Windows.Forms;
using Library_Juggle.Business_Logic_Layer;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Presentation_Layer.Authentication_Controls;
using Library_Juggle.Presentation_Layer.Shared_Controls;

namespace Library_Juggle.Presentation_Layer.Student_Controls
{
    public partial class StudentDashboardControl : UserControl
    {
        private readonly UserDataAccess _user;

        public StudentDashboardControl()
        {
            InitializeComponent();
            _user = new UserDataAccess();
            InitState();
        }

        private void InitState()
        {
            var currentUser = _user.CurrentUser();
            if (currentUser == null || currentUser.Role.RoleName != "Student")
            {
                StaticMethods.LogOutUser();
                Application.Exit();
            }
            else
            {
                StudentName.Text = currentUser.Name;
            }
            BooksViewControl booksView = new() { Dock = DockStyle.Fill };
            StudentDashboardPanel.Controls.Add(booksView);
        }

        private void CheckBookList_Click(object sender, EventArgs e)
        {
            StudentDashboardPanel.Controls.Clear();
            BooksViewControl booksView = new() { Dock = DockStyle.Fill };
            StudentDashboardPanel.Controls.Add(booksView);
        }

        private void BorrowBookButton_Click(object sender, EventArgs e)
        {
            StudentDashboardPanel.Controls.Clear();
            BorrowBookControl borrowBook = new() { Dock = DockStyle.Fill };
            StudentDashboardPanel.Controls.Add(borrowBook);
        }

        private void CheckBorrowedBooksButton_Click(object sender, EventArgs e)
        {
            StudentDashboardPanel.Controls.Clear();
            BorrowedBooksViewControl borrowedBooks = new() { Dock = DockStyle.Fill };
            StudentDashboardPanel.Controls.Add(borrowedBooks);
        }
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            StaticMethods.LogOutUser();
            Hide();
            LoginControl login = new() {Dock = DockStyle.Fill};
            Parent.Controls.Add(login);
        }
    }
}