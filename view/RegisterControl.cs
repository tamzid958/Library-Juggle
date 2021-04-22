using System;
using System.Windows.Forms;
using Library_Juggle.controller;
using Library_Juggle.model;
using Library_Juggle.service;
using MetroFramework;

namespace Library_Juggle.view
{
    public partial class RegisterControl : UserControl
    {
        private readonly UserController _user;
        private readonly LoginControl _login;
      public RegisterControl()
        {
            InitializeComponent();
            _user = new UserController();
            _login = new LoginControl();
        }

        private void SignInLink_Click(object sender, EventArgs e)
        {
            Hide();
            Parent.Controls.Add(_login);
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
                ConfirmPassword = StaticMethods.CreateMd5(confirmPassword),
                RoleId = 2
            };
            if (user.GetModelErrors() == null)
            {
                _user.CreateUser(user);
                MessageBox.Show(@"User Registered!", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                Parent.Controls.Add(_login);
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
