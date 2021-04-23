﻿using System;
using System.IO;
using System.Windows.Forms;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Presentation_Layer.auth_controls;

namespace Library_Juggle.Presentation_Layer.student_controls
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
            File.Delete(@"cookie.json");
            Hide();
            LoginControl login = new() { Dock = DockStyle.Fill };
            Parent.Controls.Add(login);
        }
    }
}