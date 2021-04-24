
namespace Library_Juggle.Presentation_Layer.Librarian_Controls
{
    partial class GiveBookLoanControl
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
            this.UserComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.BookComboBox = new MetroFramework.Controls.MetroComboBox();
            this.LoanDate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.GiveLoanBookButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.ErrorData = new System.Windows.Forms.ListBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserComboBox
            // 
            this.UserComboBox.FormattingEnabled = true;
            this.UserComboBox.ItemHeight = 23;
            this.UserComboBox.Location = new System.Drawing.Point(9, 31);
            this.UserComboBox.Name = "UserComboBox";
            this.UserComboBox.Size = new System.Drawing.Size(505, 29);
            this.UserComboBox.TabIndex = 0;
            this.UserComboBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(83, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Choose User";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(9, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Choose Book";
            // 
            // BookComboBox
            // 
            this.BookComboBox.FormattingEnabled = true;
            this.BookComboBox.ItemHeight = 23;
            this.BookComboBox.Location = new System.Drawing.Point(9, 85);
            this.BookComboBox.Name = "BookComboBox";
            this.BookComboBox.Size = new System.Drawing.Size(505, 29);
            this.BookComboBox.TabIndex = 3;
            this.BookComboBox.UseSelectable = true;
            // 
            // LoanDate
            // 
            this.LoanDate.Location = new System.Drawing.Point(9, 139);
            this.LoanDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.LoanDate.Name = "LoanDate";
            this.LoanDate.Size = new System.Drawing.Size(505, 29);
            this.LoanDate.TabIndex = 4;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(9, 117);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Loan Date";
            // 
            // GiveLoanBookButton
            // 
            this.GiveLoanBookButton.Location = new System.Drawing.Point(9, 174);
            this.GiveLoanBookButton.Name = "GiveLoanBookButton";
            this.GiveLoanBookButton.Size = new System.Drawing.Size(120, 34);
            this.GiveLoanBookButton.TabIndex = 6;
            this.GiveLoanBookButton.Text = "Give Loan";
            this.GiveLoanBookButton.UseSelectable = true;
            this.GiveLoanBookButton.Click += new System.EventHandler(this.GiveLoanBookButton_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.ErrorData);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 369);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(567, 52);
            this.metroPanel1.TabIndex = 31;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // ErrorData
            // 
            this.ErrorData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorData.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.ErrorData.ForeColor = System.Drawing.Color.DarkRed;
            this.ErrorData.FormattingEnabled = true;
            this.ErrorData.ItemHeight = 21;
            this.ErrorData.Location = new System.Drawing.Point(28, 0);
            this.ErrorData.Name = "ErrorData";
            this.ErrorData.Size = new System.Drawing.Size(399, 42);
            this.ErrorData.TabIndex = 28;
            // 
            // GiveBookLoanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.GiveLoanBookButton);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.LoanDate);
            this.Controls.Add(this.BookComboBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.UserComboBox);
            this.Controls.Add(this.metroLabel1);
            this.Name = "GiveBookLoanControl";
            this.Size = new System.Drawing.Size(567, 421);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox UserComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroDateTime LoanDate;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton LoanBookButton;
        private MetroFramework.Controls.MetroButton GiveLoanBookButton;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.ListBox ErrorData;
        private MetroFramework.Controls.MetroComboBox BookComboBox;
    }
}
