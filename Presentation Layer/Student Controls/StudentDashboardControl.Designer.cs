
namespace Library_Juggle.Presentation_Layer.Student_Controls
{
    partial class StudentDashboardControl
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
            this.StudentName = new MetroFramework.Controls.MetroLabel();
            this.LogOutButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.CheckBorrowedBooksButton = new MetroFramework.Controls.MetroButton();
            this.BorrowBookButton = new MetroFramework.Controls.MetroButton();
            this.CheckBookList = new MetroFramework.Controls.MetroButton();
            this.StudentDashboardPanel = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Dock = System.Windows.Forms.DockStyle.Top;
            this.StudentName.Location = new System.Drawing.Point(0, 0);
            this.StudentName.Name = "StudentName";
            this.StudentName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StudentName.Size = new System.Drawing.Size(116, 19);
            this.StudentName.TabIndex = 0;
            this.StudentName.Text = "Student Logged In";
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.DarkRed;
            this.LogOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogOutButton.Location = new System.Drawing.Point(10, 354);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(180, 38);
            this.LogOutButton.TabIndex = 1;
            this.LogOutButton.Text = "Sign Out";
            this.LogOutButton.UseCustomBackColor = true;
            this.LogOutButton.UseCustomForeColor = true;
            this.LogOutButton.UseSelectable = true;
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.StudentName);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 421);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.CheckBorrowedBooksButton);
            this.metroPanel2.Controls.Add(this.BorrowBookButton);
            this.metroPanel2.Controls.Add(this.CheckBookList);
            this.metroPanel2.Controls.Add(this.LogOutButton);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 19);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.metroPanel2.Size = new System.Drawing.Size(200, 402);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // CheckBorrowedBooksButton
            // 
            this.CheckBorrowedBooksButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckBorrowedBooksButton.Location = new System.Drawing.Point(10, 86);
            this.CheckBorrowedBooksButton.Name = "CheckBorrowedBooksButton";
            this.CheckBorrowedBooksButton.Size = new System.Drawing.Size(180, 38);
            this.CheckBorrowedBooksButton.TabIndex = 9;
            this.CheckBorrowedBooksButton.Text = "Check Borrowed Books";
            this.CheckBorrowedBooksButton.UseSelectable = true;
            this.CheckBorrowedBooksButton.Click += new System.EventHandler(this.CheckBorrowedBooksButton_Click);
            // 
            // BorrowBookButton
            // 
            this.BorrowBookButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BorrowBookButton.Location = new System.Drawing.Point(10, 48);
            this.BorrowBookButton.Name = "BorrowBookButton";
            this.BorrowBookButton.Size = new System.Drawing.Size(180, 38);
            this.BorrowBookButton.TabIndex = 8;
            this.BorrowBookButton.Text = "Borrow Book";
            this.BorrowBookButton.UseSelectable = true;
            this.BorrowBookButton.Click += new System.EventHandler(this.BorrowBookButton_Click);
            // 
            // CheckBookList
            // 
            this.CheckBookList.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckBookList.Location = new System.Drawing.Point(10, 10);
            this.CheckBookList.Name = "CheckBookList";
            this.CheckBookList.Size = new System.Drawing.Size(180, 38);
            this.CheckBookList.TabIndex = 7;
            this.CheckBookList.Text = "Check Book List";
            this.CheckBookList.UseSelectable = true;
            this.CheckBookList.Click += new System.EventHandler(this.CheckBookList_Click);
            // 
            // StudentDashboardPanel
            // 
            this.StudentDashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StudentDashboardPanel.HorizontalScrollbarBarColor = true;
            this.StudentDashboardPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.StudentDashboardPanel.HorizontalScrollbarSize = 10;
            this.StudentDashboardPanel.Location = new System.Drawing.Point(200, 0);
            this.StudentDashboardPanel.Name = "StudentDashboardPanel";
            this.StudentDashboardPanel.Size = new System.Drawing.Size(567, 421);
            this.StudentDashboardPanel.TabIndex = 3;
            this.StudentDashboardPanel.VerticalScrollbarBarColor = true;
            this.StudentDashboardPanel.VerticalScrollbarHighlightOnWheel = false;
            this.StudentDashboardPanel.VerticalScrollbarSize = 10;
            // 
            // StudentDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StudentDashboardPanel);
            this.Controls.Add(this.metroPanel1);
            this.Name = "StudentDashboardControl";
            this.Size = new System.Drawing.Size(767, 421);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel StudentName;
        private MetroFramework.Controls.MetroButton LogOutButton;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton CheckBookList;
        private MetroFramework.Controls.MetroButton BorrowBookButton;
        private MetroFramework.Controls.MetroButton CheckBorrowedBooksButton;
        private MetroFramework.Controls.MetroPanel StudentDashboardPanel;
    }
}
