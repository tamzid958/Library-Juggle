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

namespace Library_Juggle.view.admin_controls
{
    public partial class AddLibrarianControl : UserControl
    {
        private readonly UserController _user;
        private readonly List<User> _users;
        private readonly List<Role> _roles;
        public AddLibrarianControl()
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
            foreach (var user in _users)
            {
                UserComboBox.Items.Add(new KeyValuePair<int, string>(user.UserId, user.Email) + " => " + user.Role.RoleName);
            }
        }

        private void MarkAsLibrarian_Click(object sender, EventArgs e)
        {
            if(UserComboBox.SelectedItem == null) return;
            var selected = UserComboBox.SelectedItem.ToString();
            var start = selected!.IndexOf("[", StringComparison.Ordinal) + 1;
            var end = selected!.IndexOf(",", start, StringComparison.Ordinal);
            var userId = int.Parse(selected!.Substring(start, end - start));
           if(_user.GetUser(userId) == null) return; 
           _user.UpdateRole(userId, 3);
           InitState();
        }
    }
}
