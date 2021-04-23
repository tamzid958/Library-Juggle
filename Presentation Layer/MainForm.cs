using System.Windows.Forms;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Presentation_Layer.admin_controls;
using Library_Juggle.Presentation_Layer.auth_controls;
using Library_Juggle.Presentation_Layer.student_controls;
using MetroFramework.Forms;

namespace Library_Juggle.Presentation_Layer
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
