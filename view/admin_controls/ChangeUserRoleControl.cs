using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Juggle.controller;
using Library_Juggle.model;
using MetroFramework;

namespace Library_Juggle.view.admin_controls
{
    public partial class ChangeUserRoleControl : UserControl
    {
        private readonly UserController _user;
        private readonly List<User> _users;
        private readonly List<Role> _roles;
        public ChangeUserRoleControl()
        {
            InitializeComponent();
            _user = new UserController();
            var role = new RoleController();
            _users = _user.GetAllUsers();
            _roles = role.GetAllRoles();
            InitState();
        }

        private void InitState()
        {
            
            UserDataGridView.DataSource = null; 
            UserComboBox.Items.Clear();
            RoleComboBox.Items.Clear();
            var roleComboBoxColumn = new DataGridViewComboBoxColumn()
            {
                HeaderText = @"Role",
                Name = @"UserDataGridRole",
                DataPropertyName = @"RoleId",
                DataSource = _roles,
                DisplayMember = @"RoleName",
                ValueMember = @"RoleId",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            UserDataGridView.DataSource = _users;
            UserDataGridView.Columns[0].Visible = UserDataGridView.Columns[3].Visible = UserDataGridView.Columns[4].Visible 
                = UserDataGridView.Columns[5].Visible = UserDataGridView.Columns[6].Visible = UserDataGridView.Columns[7].Visible 
                    = UserDataGridView.Columns[8].Visible = UserDataGridView.Columns[9].Visible = false;
            UserDataGridView.Columns.Add(roleComboBoxColumn);
            
            UserComboBox.Items.Add("Select User From List");
            UserComboBox.SelectedIndex = 0;
            RoleComboBox.Items.Add("Select Role From List");
            RoleComboBox.SelectedIndex = 0;
            foreach (var user in _users)
            {
                UserComboBox.Items.Add(new KeyValuePair<int, string>(user.UserId, user.Email) + " => " + user.Role.RoleName);
            }

            foreach (var role in _roles)
            {
                RoleComboBox.Items.Add(new KeyValuePair<int, string>(role.RoleId, role.RoleName));
            }
        }

        private void ChangeRoleButton_Click(object sender, EventArgs e)
        {
            if(UserComboBox.SelectedItem == null 
               || UserComboBox.SelectedIndex == 0 
               || RoleComboBox.SelectedItem == null 
               || RoleComboBox.SelectedIndex == 0) return;
            var userSelected = UserComboBox.SelectedItem.ToString();
            var roleSelected = RoleComboBox.SelectedItem.ToString();
            var start = userSelected!.IndexOf("[", StringComparison.Ordinal) + 1;
            var end = userSelected!.IndexOf(",", start, StringComparison.Ordinal);
            var userId = int.Parse(userSelected![start..end]);

            start = roleSelected!.IndexOf("[", StringComparison.Ordinal) + 1;
            end = roleSelected!.IndexOf(",", start, StringComparison.Ordinal);
            var roleId = int.Parse(roleSelected![start..end]);

            if (_user.GetUser(userId) == null) return; 
           _user.UpdateRole(userId, roleId);
           try
           {
               MetroMessageBox.Show(this, @"User Role Changed!", @"Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
           catch (Exception exception)
           {
               Console.WriteLine(exception);
           }
            InitState();
        }
    }
}
