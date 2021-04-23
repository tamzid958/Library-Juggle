
namespace Library_Juggle.Presentation_Layer.Admin_Controls
{
    partial class UsersViewControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.UserDataGridView = new MetroFramework.Controls.MetroGrid();
            this.UserComboBox = new MetroFramework.Controls.MetroComboBox();
            this.ChangeRoleButton = new MetroFramework.Controls.MetroButton();
            this.RoleComboBox = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.AllowUserToResizeRows = false;
            this.UserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.UserDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.UserDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserDataGridView.EnableHeadersVisualStyles = false;
            this.UserDataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserDataGridView.Location = new System.Drawing.Point(0, 181);
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.ReadOnly = true;
            this.UserDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.UserDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.UserDataGridView.RowTemplate.Height = 25;
            this.UserDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDataGridView.Size = new System.Drawing.Size(567, 240);
            this.UserDataGridView.Style = MetroFramework.MetroColorStyle.Lime;
            this.UserDataGridView.TabIndex = 2;
            // 
            // UserComboBox
            // 
            this.UserComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.ItemHeight = 23;
            this.UserComboBox.Location = new System.Drawing.Point(0, 0);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(567, 29);
            this.UserComboBox.TabIndex = 4;
            this.UserComboBox.UseSelectable = true;
            // 
            // ChangeRoleButton
            // 
            this.ChangeRoleButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChangeRoleButton.Location = new System.Drawing.Point(0, 158);
            this.ChangeRoleButton.Name = "ChangeRoleButton";
            this.ChangeRoleButton.Size = new System.Drawing.Size(567, 23);
            this.ChangeRoleButton.TabIndex = 5;
            this.ChangeRoleButton.Text = "Change Role";
            this.ChangeRoleButton.UseSelectable = true;
            this.ChangeRoleButton.Click += new System.EventHandler(this.ChangeRoleButton_Click);
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.ItemHeight = 23;
            this.RoleComboBox.Location = new System.Drawing.Point(0, 29);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(567, 29);
            this.RoleComboBox.TabIndex = 6;
            this.RoleComboBox.UseSelectable = true;
            // 
            // ChangeUserRoleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.ChangeRoleButton);
            this.Controls.Add(this.UserComboBox);
            this.Controls.Add(this.UserDataGridView);
            this.Name = "UsersViewControl";
            this.Size = new System.Drawing.Size(567, 421);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroComboBox LibrarianList;
        private MetroFramework.Controls.MetroListView UserList;
        private MetroFramework.Controls.MetroGrid UserDataGridView;
        private MetroFramework.Controls.MetroComboBox UserComboBox;
        private MetroFramework.Controls.MetroButton ChangeRoleButton;
        private MetroFramework.Controls.MetroComboBox RoleComboBox;
    }
}
