
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
            this.LogOutButton = new MetroFramework.Controls.MetroButton();
            this.AdminName = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogOutButton
            // 
            this.LogOutButton.Location = new System.Drawing.Point(30, 327);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(131, 28);
            this.LogOutButton.TabIndex = 3;
            this.LogOutButton.Text = "Sign Out";
            this.LogOutButton.UseSelectable = true;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // AdminName
            // 
            this.AdminName.AutoSize = true;
            this.AdminName.Location = new System.Drawing.Point(30, 52);
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(111, 19);
            this.AdminName.TabIndex = 2;
            this.AdminName.Text = "Admin Logged In";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.LogOutButton);
            this.metroPanel1.Controls.Add(this.AdminName);
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
            // AdminDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "AdminDashboardControl";
            this.Size = new System.Drawing.Size(767, 421);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton LogOutButton;
        private MetroFramework.Controls.MetroLabel AdminName;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}
