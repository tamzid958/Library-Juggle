using System.IO;
using System.Windows.Forms;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Presentation_Layer.auth_controls;

namespace Library_Juggle.Presentation_Layer.admin_controls
{
    public partial class AdminDashboardControl : UserControl
    {

        private readonly UserController _user;
        public AdminDashboardControl()
        {
            InitializeComponent();
            _user = new UserController();
            InitState();
        }
        private void InitState()
        {
            var currentUser = _user.CurrentUser();
            if (currentUser == null)
            {
                Hide();
                LoginControl login = new() { Dock = DockStyle.Fill };
                Parent.Controls.Add(login);
            }
            else
            {
                AdminName.Text = currentUser.Name;
            }
            ChangeUserRoleControl addLibrarian = new() { Dock = DockStyle.Fill };
            AdminDashboardPanel.Controls.Add(addLibrarian);

        }

        private void LogOutButton_Click(object sender, System.EventArgs e)
        {
            File.Delete(@"cookie.json");
            Hide();
            LoginControl login = new() { Dock = DockStyle.Fill };
            Parent.Controls.Add(login);
        }

        private void CheckUserListButton_Click(object sender, System.EventArgs e)
        {
            AdminDashboardPanel.Controls.Clear();
            ChangeUserRoleControl addLibrarian = new() { Dock = DockStyle.Fill };
            AdminDashboardPanel.Controls.Add(addLibrarian);
        }

        private void CheckBookList_Click(object sender, System.EventArgs e)
        {
            AdminDashboardPanel.Controls.Clear();
            BooksViewControl booksView = new() { Dock = DockStyle.Fill };
            AdminDashboardPanel.Controls.Add(booksView);
        }
    }
}
