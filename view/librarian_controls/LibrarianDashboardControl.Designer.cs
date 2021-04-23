
namespace Library_Juggle.view.librarian_controls
{
    partial class LibrarianDashboardControl
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.LogOutButton = new MetroFramework.Controls.MetroButton();
            this.LibrarianName = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.LogOutButton);
            this.metroPanel1.Controls.Add(this.LibrarianName);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 421);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.DarkRed;
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogOutButton.Location = new System.Drawing.Point(30, 74);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(95, 28);
            this.LogOutButton.TabIndex = 4;
            this.LogOutButton.Text = "Sign Out";
            this.LogOutButton.UseCustomBackColor = true;
            this.LogOutButton.UseCustomForeColor = true;
            this.LogOutButton.UseSelectable = true;
            this.LogOutButton.UseVisualStyleBackColor = false;
            // 
            // LibrarianName
            // 
            this.LibrarianName.AutoSize = true;
            this.LibrarianName.Location = new System.Drawing.Point(30, 52);
            this.LibrarianName.Name = "LibrarianName";
            this.LibrarianName.Size = new System.Drawing.Size(123, 19);
            this.LibrarianName.TabIndex = 2;
            this.LibrarianName.Text = "Librarian Logged In";
            // 
            // LibrarianDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "LibrarianDashboardControl";
            this.Size = new System.Drawing.Size(767, 421);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton LogOutButton;
        private MetroFramework.Controls.MetroLabel LibrarianName;
    }
}
