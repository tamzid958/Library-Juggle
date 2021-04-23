using System;
using System.Windows.Forms;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Presentation_Layer.admin_controls;
using Library_Juggle.Presentation_Layer.student_controls;

namespace Library_Juggle.Presentation_Layer.auth_controls
{
    public partial class LoginControl : UserControl
    {
        private readonly UserController _user;
        public LoginControl()
        {
            InitializeComponent();
            _user = new UserController();
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
                case "Student":
                    StudentDashboardControl studentDashboard = new() { Dock = DockStyle.Fill };
                    Parent.Controls.Add(studentDashboard);
                    break;
            }
        }
    }
}
