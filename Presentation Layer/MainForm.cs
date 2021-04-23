using System.Windows.Forms;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Presentation_Layer.Admin_Controls;
using Library_Juggle.Presentation_Layer.Auth_Controls;
using Library_Juggle.Presentation_Layer.Librarian_Controls;
using Library_Juggle.Presentation_Layer.Student_Controls;
using MetroFramework.Forms;

namespace Library_Juggle.Presentation_Layer
{
    public partial class MainForm : MetroForm
    {
        private readonly UserDataAccess _user;
        public MainForm()
        {
            InitializeComponent();
            _user = new UserDataAccess();
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
                    case "Librarian":
                        LibrarianDashboardControl librarianDashboard = new() {Dock = DockStyle.Fill};
                        Controls.Add(librarianDashboard);
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
