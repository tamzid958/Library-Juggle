
namespace Library_Juggle.Presentation_Layer.Librarian_Controls
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
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.GiveBookLoan = new MetroFramework.Controls.MetroButton();
            this.CheckLoanList = new MetroFramework.Controls.MetroButton();
            this.AddNewBook = new MetroFramework.Controls.MetroButton();
            this.CheckBookList = new MetroFramework.Controls.MetroButton();
            this.CheckUserList = new MetroFramework.Controls.MetroButton();
            this.LogOutButton = new MetroFramework.Controls.MetroButton();
            this.LibrarianName = new MetroFramework.Controls.MetroLabel();
            this.LibrarianDashboardPanel = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel2);
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
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.GiveBookLoan);
            this.metroPanel2.Controls.Add(this.CheckLoanList);
            this.metroPanel2.Controls.Add(this.AddNewBook);
            this.metroPanel2.Controls.Add(this.CheckBookList);
            this.metroPanel2.Controls.Add(this.CheckUserList);
            this.metroPanel2.Controls.Add(this.LogOutButton);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 19);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.metroPanel2.Size = new System.Drawing.Size(200, 402);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // GiveBookLoan
            // 
            this.GiveBookLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.GiveBookLoan.Location = new System.Drawing.Point(10, 162);
            this.GiveBookLoan.Name = "GiveBookLoan";
            this.GiveBookLoan.Size = new System.Drawing.Size(180, 38);
            this.GiveBookLoan.TabIndex = 9;
            this.GiveBookLoan.Text = "Give Book Loan";
            this.GiveBookLoan.UseSelectable = true;
            this.GiveBookLoan.Click += new System.EventHandler(this.GiveBookLoan_Click);
            // 
            // CheckLoanList
            // 
            this.CheckLoanList.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckLoanList.Location = new System.Drawing.Point(10, 124);
            this.CheckLoanList.Name = "CheckLoanList";
            this.CheckLoanList.Size = new System.Drawing.Size(180, 38);
            this.CheckLoanList.TabIndex = 8;
            this.CheckLoanList.Text = "Check Loan List";
            this.CheckLoanList.UseSelectable = true;
            this.CheckLoanList.Click += new System.EventHandler(this.CheckLoanList_Click);
            // 
            // AddNewBook
            // 
            this.AddNewBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddNewBook.Location = new System.Drawing.Point(10, 86);
            this.AddNewBook.Name = "AddNewBook";
            this.AddNewBook.Size = new System.Drawing.Size(180, 38);
            this.AddNewBook.TabIndex = 7;
            this.AddNewBook.Text = "Add New Book";
            this.AddNewBook.UseSelectable = true;
            this.AddNewBook.Click += new System.EventHandler(this.AddNewBook_Click);
            // 
            // CheckBookList
            // 
            this.CheckBookList.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckBookList.Location = new System.Drawing.Point(10, 48);
            this.CheckBookList.Name = "CheckBookList";
            this.CheckBookList.Size = new System.Drawing.Size(180, 38);
            this.CheckBookList.TabIndex = 6;
            this.CheckBookList.Text = "Check Book List";
            this.CheckBookList.UseSelectable = true;
            this.CheckBookList.Click += new System.EventHandler(this.CheckBookList_Click);
            // 
            // CheckUserList
            // 
            this.CheckUserList.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckUserList.Location = new System.Drawing.Point(10, 10);
            this.CheckUserList.Name = "CheckUserList";
            this.CheckUserList.Size = new System.Drawing.Size(180, 38);
            this.CheckUserList.TabIndex = 5;
            this.CheckUserList.Text = "Check User List";
            this.CheckUserList.UseSelectable = true;
            this.CheckUserList.Click += new System.EventHandler(this.CheckUserList_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.DarkRed;
            this.LogOutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogOutButton.Location = new System.Drawing.Point(10, 354);
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
            // LibrarianName
            // 
            this.LibrarianName.AutoSize = true;
            this.LibrarianName.Dock = System.Windows.Forms.DockStyle.Top;
            this.LibrarianName.Location = new System.Drawing.Point(0, 0);
            this.LibrarianName.Name = "LibrarianName";
            this.LibrarianName.Size = new System.Drawing.Size(123, 19);
            this.LibrarianName.TabIndex = 2;
            this.LibrarianName.Text = "Librarian Logged In";
            // 
            // LibrarianDashboardPanel
            // 
            this.LibrarianDashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LibrarianDashboardPanel.HorizontalScrollbarBarColor = true;
            this.LibrarianDashboardPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.LibrarianDashboardPanel.HorizontalScrollbarSize = 10;
            this.LibrarianDashboardPanel.Location = new System.Drawing.Point(200, 0);
            this.LibrarianDashboardPanel.Name = "LibrarianDashboardPanel";
            this.LibrarianDashboardPanel.Size = new System.Drawing.Size(567, 421);
            this.LibrarianDashboardPanel.TabIndex = 6;
            this.LibrarianDashboardPanel.VerticalScrollbarBarColor = true;
            this.LibrarianDashboardPanel.VerticalScrollbarHighlightOnWheel = false;
            this.LibrarianDashboardPanel.VerticalScrollbarSize = 10;
            // 
            // LibrarianDashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LibrarianDashboardPanel);
            this.Controls.Add(this.metroPanel1);
            this.Name = "LibrarianDashboardControl";
            this.Size = new System.Drawing.Size(767, 421);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton LogOutButton;
        private MetroFramework.Controls.MetroLabel LibrarianName;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton CheckUserList;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton CheckBookList;
        private MetroFramework.Controls.MetroButton AddNewBook;
        private MetroFramework.Controls.MetroButton CheckLoanList;
        private MetroFramework.Controls.MetroButton GiveBookLoan;
        private MetroFramework.Controls.MetroPanel LibrarianDashboardPanel;
    }
}
