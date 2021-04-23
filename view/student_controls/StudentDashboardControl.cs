using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Juggle.controller;
using Library_Juggle.model;
using Library_Juggle.view.auth_controls;

namespace Library_Juggle.view.student_controls
{
    public partial class StudentDashboardControl : UserControl
    {
        private readonly UserController _user; 
        public StudentDashboardControl()
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
                LoginControl login = new();
                Parent.Controls.Add(login);
            }
            else
            {
                StudentName.Text = currentUser.Name;
            }
            
        }
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            File.Delete(@"cookie.json");
            Hide();
            LoginControl login = new();
            Parent.Controls.Add(login);
        }
    }
}
