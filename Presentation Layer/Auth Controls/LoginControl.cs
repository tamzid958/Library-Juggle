using System;
using System.Windows.Forms;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Presentation_Layer.Admin_Controls;
using Library_Juggle.Presentation_Layer.Librarian_Controls;
using Library_Juggle.Presentation_Layer.Student_Controls;

namespace Library_Juggle.Presentation_Layer.Auth_Controls
{
    public partial class LoginControl : UserControl
    {
        private readonly UserDataAccess _user;
        public LoginControl()
        {
            InitializeComponent();
            _user = new UserDataAccess();
        }

        private void SignUpLink_Click(object sender, EventArgs e)
        {
            RegisterControl register = new() { Dock = DockStyle.Fill };
            Hide();
            Parent.Controls.Add(register);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            ErrorData.Items.Clear();
            var email = UserEmail.Text;
            var password = UserPassword.Text;
            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                ErrorData.Items.Add("Email & Password Required");
                return;
            }
            var currentUser = _user.Authentication(email, password);
            if(currentUser == null)
            {
                ErrorData.Items.Add("Invalid Cardinalities");
                return;
            }
            Hide();
            switch (currentUser.Role.RoleName)
            {
                case "Admin":
                    AdminDashboardControl adminDashboard = new() { Dock = DockStyle.Fill };
                    Parent.Controls.Add(adminDashboard);
                    break;
                case "Librarian":
                    LibrarianDashboardControl librarianDashboard = new() {Dock = DockStyle.Fill};
                    Parent.Controls.Add(librarianDashboard);
                    break;
                case "Student":
                    StudentDashboardControl studentDashboard = new() { Dock = DockStyle.Fill };
                    Parent.Controls.Add(studentDashboard);
                    break;
                default:
                    Application.Exit();
                    break;
            }
        }
    }
}
