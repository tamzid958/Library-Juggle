using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using Library_Juggle.controller;
using Library_Juggle.model;
using Library_Juggle.view.admin_controls;
using Library_Juggle.view.student_controls;

namespace Library_Juggle.view.auth_controls
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
            RegisterControl register = new();
            this.Hide();
            this.Parent.Controls.Add(register);
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
            this.Hide();
            switch (currentUser.Role.RoleName)
            {
                case "Admin":
                    AdminDashboardControl adminDashboard = new();
                    this.Parent.Controls.Add(adminDashboard);
                    break;
                case "Student":
                    StudentDashboardControl studentDashboard = new();
                    this.Parent.Controls.Add(studentDashboard);
                    break;
            }
        }
    }
}
