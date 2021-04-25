using System;
using System.Windows.Forms;
using Library_Juggle.Business_Logic_Layer;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Presentation_Layer.Authentication_Controls;
using Library_Juggle.Presentation_Layer.Shared_Controls;

namespace Library_Juggle.Presentation_Layer.Librarian_Controls
{
    public partial class LibrarianDashboardControl : UserControl
    {
        private readonly UserDataAccess _user;

        public LibrarianDashboardControl()
        {
            InitializeComponent();
            _user = new UserDataAccess();
            InitState();
        }

        private void InitState()
        {
            var currentUser = _user.CurrentUser();
            if (currentUser == null || currentUser.Role.RoleName != "Librarian")
            {
                StaticMethods.LogOutUser();
                Application.Exit();
            }
            else
            {
                LibrarianName.Text = currentUser.Name;
            }

            UsersViewControl usersView = new() {Dock = DockStyle.Fill};
            LibrarianDashboardPanel.Controls.Add(usersView);
        }

        private void CheckUserList_Click(object sender, EventArgs e)
        {
            LibrarianDashboardPanel.Controls.Clear();
            UsersViewControl usersView = new() {Dock = DockStyle.Fill};
            LibrarianDashboardPanel.Controls.Add(usersView);
        }

        private void CheckBookList_Click(object sender, EventArgs e)
        {
            LibrarianDashboardPanel.Controls.Clear();
            BooksViewControl booksView = new() {Dock = DockStyle.Fill};
            LibrarianDashboardPanel.Controls.Add(booksView);
        }

        private void CheckLoanList_Click(object sender, EventArgs e)
        {
            LibrarianDashboardPanel.Controls.Clear();
            LoansViewControl loansView = new() {Dock = DockStyle.Fill};
            LibrarianDashboardPanel.Controls.Add(loansView);
        }

        private void AddNewBook_Click(object sender, EventArgs e)
        {
            LibrarianDashboardPanel.Controls.Clear();
            AddNewBookControl addNewBook = new() {Dock = DockStyle.Fill};
            LibrarianDashboardPanel.Controls.Add(addNewBook);
        }

        private void GiveBookLoan_Click(object sender, EventArgs e)
        {
            LibrarianDashboardPanel.Controls.Clear();
            GiveBookLoanControl giveBookLoan = new() {Dock = DockStyle.Fill};
            LibrarianDashboardPanel.Controls.Add(giveBookLoan);
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