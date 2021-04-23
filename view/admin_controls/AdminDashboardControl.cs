using System.IO;
using System.Windows.Forms;
using Library_Juggle.controller;
using Library_Juggle.view.auth_controls;

namespace Library_Juggle.view.admin_controls
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

        }

        private void LogOutButton_Click(object sender, System.EventArgs e)
        {
            File.Delete(@"cookie.json");
            Hide();
            LoginControl login = new() { Dock = DockStyle.Fill };
            Parent.Controls.Add(login);
        }
    }
}
