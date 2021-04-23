using System;
using System.IO;
using System.Windows.Forms;
using Library_Juggle.Business_Logic_Layer;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Presentation_Layer.Auth_Controls;

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
                Hide();
                LoginControl login = new() { Dock = DockStyle.Fill };
                Parent.Controls.Add(login);
            }
            else
            {
                StudentName.Text = currentUser.Name;
            }
            
        }
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            StaticMethods.LogOutUser();
            Hide();
            LoginControl login = new() { Dock = DockStyle.Fill };
            Parent.Controls.Add(login);
        }
    }
}
