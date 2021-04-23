
namespace Library_Juggle.view.admin_controls
{
    partial class AdminDashboardControl
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
            this.AdminName = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.AddLibrarianButton = new MetroFramework.Controls.MetroButton();
            this.LogOutButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.AdminDashboardPanel = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminName
            // 
            this.AdminName.AutoSize = true;
            this.AdminName.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminName.Location = new System.Drawing.Point(0, 0);
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(111, 19);
            this.AdminName.TabIndex = 2;
            this.AdminName.Text = "Admin Logged In";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 421);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.LogOutButton);
            this.metroPanel3.Controls.Add(this.AddLibrarianButton);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 30);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Padding = new System.Windows.Forms.Padding(10);
            this.metroPanel3.Size = new System.Drawing.Size(200, 391);
            this.metroPanel3.TabIndex = 6;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // AddLibrarianButton
            // 
            this.AddLibrarianButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddLibrarianButton.Location = new System.Drawing.Point(10, 10);
            this.AddLibrarianButton.Name = "AddLibrarianButton";
            this.AddLibrarianButton.Size = new System.Drawing.Size(180, 38);
            this.AddLibrarianButton.TabIndex = 2;
            this.AddLibrarianButton.Text = " Add Librarian";
            this.AddLibrarianButton.UseSelectable = true;
            this.AddLibrarianButton.Click += new System.EventHandler(this.AddLibrarianButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.DarkRed;
            this.LogOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogOutButton.Location = new System.Drawing.Point(10, 343);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(10);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(180, 38);
            this.LogOutButton.TabIndex = 4;
            this.LogOutButton.Text = "Sign Out";
            this.LogOutButton.UseCustomBackColor = true;
            this.LogOutButton.UseCustomForeColor = true;
            this.LogOutButton.UseSelectable = true;
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.AdminName);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(200, 30);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // AdminDashboardPanel
            // 
            this.AdminDashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminDashboardPanel.HorizontalScrollbarBarColor = true;
            this.AdminDashboardPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.AdminDashboardPanel.HorizontalScrollbarSize = 10;
            this.AdminDashboardPanel.Location = new System.Drawing.Point(200, 0);
            this.AdminDashboardPanel.Name = "AdminDashboardPanel";
            this.AdminDashboardPanel.Size = new System.Drawing.Size(567, 421);
            this.AdminDashboardPanel.TabIndex = 5;
            this.AdminDashboardPanel.VerticalScrollbarBarColor = true;
            this.AdminDashboardPanel.VerticalScrollbarHighlightOnWheel = false;
            this.AdminDashboardPanel.VerticalScrollbarSize = 10;
            // 
            // AdminDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdminDashboardPanel);
            this.Controls.Add(this.metroPanel1);
            this.Name = "AdminDashboardControl";
            this.Size = new System.Drawing.Size(767, 421);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel AdminName;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel AdminDashboardPanel;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton AddLibrarianButton;
        private MetroFramework.Controls.MetroButton LogOutButton;
    }
}
