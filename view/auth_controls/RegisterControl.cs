using System;
using System.Windows.Forms;
using Library_Juggle.controller;
using Library_Juggle.model;
using Library_Juggle.service;
using MetroFramework;

namespace Library_Juggle.view.auth_controls
{
    public partial class RegisterControl : UserControl
    {
        private readonly UserController _user;
        public RegisterControl()
        {
            InitializeComponent();
            _user = new UserController();
        }

        private void SignInLink_Click(object sender, EventArgs e)
        {
            LoginControl login = new() { Dock = DockStyle.Fill };
            Hide();
            Parent.Controls.Add(login);
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var password = UserPassword.Text;
            var confirmPassword = UserConfirmPassword.Text;
            var email = UserEmail.Text;
            var name = UserName.Text;

            ErrorData.Items.Clear();

            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                ErrorData.Items.Add("Password Required");
                return;
            }

            if (password != confirmPassword)
            {
                ErrorData.Items.Add("Password and Confirm Password not matched");
                return;
            }

            if (password.Length < 5 || confirmPassword.Length < 5)
            {
                ErrorData.Items.Add("Password is weak");
                return;
            }

            if (_user.DuplicateUser(email) > 0)
            {
                ErrorData.Items.Add("Duplicate User Found!");
                return;
            }

            var user = new User
            {
                Name = name,
                Email = email,
                Password = StaticMethods.CreateMd5(password),
                Token = StaticMethods.CreateMd5(email),
                RoleId = 2
            };


            if (user.GetModelErrors() == null)
            {
                _user.CreateUser(user);
                try
                {
                    MetroMessageBox.Show(this,@"User Registered!", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
                LoginControl login = new() { Dock = DockStyle.Fill };
                Hide();
                Parent.Controls.Add(login);
            }
            else
            {
                foreach (var errors in user.GetModelErrors())
                {
                    ErrorData.Items.Add(errors.ErrorMessage!);
                }

            }
        }
    }
}
