using System.Windows.Forms;
using Library_Juggle.controller;
using Library_Juggle.view.admin_controls;
using Library_Juggle.view.auth_controls;
using Library_Juggle.view.student_controls;
using MetroFramework.Forms;
namespace Library_Juggle.view
{
    public partial class MainForm : MetroForm
    {
        private readonly UserController _user;
        public MainForm()
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
                LoginControl login = new() { Dock = DockStyle.Fill };
                Controls.Add(login);
            }
            else
            {
                switch (currentUser.Role.RoleName)
                {
                    case "Admin":
                        AdminDashboardControl adminDashboard = new() { Dock = DockStyle.Fill };
                        Controls.Add(adminDashboard);
                        break;
                    case "Student":
                        StudentDashboardControl studentDashboard = new() { Dock = DockStyle.Fill };
                        Controls.Add(studentDashboard);
                        break;
                }
            }
        }
       
    }
}
