using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Library_Juggle.Business_Logic_Layer;
using Library_Juggle.Data_Access_Layer;
using Library_Juggle.Data_Access_Layer.Entities;
using MetroFramework;

namespace Library_Juggle.Presentation_Layer.Shared_Controls
{
    public partial class UsersViewControl : UserControl
    {
        private readonly List<Role> _roles;
        private readonly UserDataAccess _user;
        private List<User> _users;

        public UsersViewControl()
        {
            InitializeComponent();
            _user = new UserDataAccess();
            var role = new RoleDataAccess();
            _roles = role.GetAllRoles();
            InitState();
        }

        private void InitState()
        {
            _users = _user.GetAllUsers();

            UserDataGridView.DataSource = null;
            UserComboBox.Items.Clear();
            RoleComboBox.Items.Clear();
            var roleComboBoxColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = @"Role",
                Name = @"UserDataGridRole",
                DataPropertyName = @"RoleId",
                DataSource = _roles,
                DisplayMember = @"RoleName",
                ValueMember = @"RoleId",
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
            var deleteButtonsColumn = new DataGridViewButtonColumn
            {
                HeaderText = @"Delete",
                Name = @"UserDataGridUserDelete",
                DataPropertyName = @"UserId",
                UseColumnTextForButtonValue = true,
                Text = @"Delete",
                FlatStyle = FlatStyle.Flat,
            };
            UserDataGridView.DataSource = _user.GetAllUsers();
            UserDataGridView.Columns[0].Visible = UserDataGridView.Columns[3].Visible =
                UserDataGridView.Columns[4].Visible
                    = UserDataGridView.Columns[5].Visible = UserDataGridView.Columns[6].Visible =
                        UserDataGridView.Columns[7].Visible = false;
            UserDataGridView.Columns.AddRange(roleComboBoxColumn, deleteButtonsColumn);

            UserComboBox.Items.Add("Select User From List");
            UserComboBox.SelectedIndex = 0;
            RoleComboBox.Items.Add("Select Role From List");
            RoleComboBox.SelectedIndex = 0;
            foreach (var user in _users) UserComboBox.Items.Add(new KeyValuePair<int, string>(user.UserId, user.Email));

            foreach (var role in _roles) RoleComboBox.Items.Add(new KeyValuePair<int, string>(role.RoleId, role.RoleName));
            if (_user.CurrentUser().Role.RoleName is not "Admin") 
                UserComboBox.Visible = RoleComboBox.Visible = ChangeRoleButton.Visible = false;
        }

        private void ChangeRoleButton_Click(object sender, EventArgs e)
        {
            if (UserComboBox.SelectedItem == null
                || UserComboBox.SelectedIndex == 0
                || RoleComboBox.SelectedItem == null
                || RoleComboBox.SelectedIndex == 0) return;

            var userId = StaticMethods.CastFromObjectToKeyValuePair<int, string>(UserComboBox.SelectedItem).Key;
            var roleId = StaticMethods.CastFromObjectToKeyValuePair<int, string>(RoleComboBox.SelectedItem).Key;

            if (_user.GetUser(userId) == null) return;
            _user.UpdateRole(userId, roleId);
            try
            {
                MetroMessageBox.Show(this, @"User Role Changed!", @"Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            InitState();
        }

        private void UserDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 9 || UserDataGridView.CurrentRow == null) return;
            var userId = int.Parse(StaticMethods.GridViewDataAccess(UserDataGridView, "UserId"));
            var selectedUser = _user.GetUser(userId);
            if (_user.CurrentUser().UserId == userId || selectedUser.Role.RoleName == "Admin") return; 
            try
            {
                _user.DeleteUser(userId);
                MetroMessageBox.Show(this, @"User Deleted!", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            InitState();
        }
    }
}