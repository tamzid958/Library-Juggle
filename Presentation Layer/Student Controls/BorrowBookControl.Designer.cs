
namespace Library_Juggle.Presentation_Layer.Student_Controls
{
    partial class BorrowBookControl
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
            this.ErrorData = new System.Windows.Forms.ListBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.ReturnedDaysComboBox = new MetroFramework.Controls.MetroComboBox();
            this.BookComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TakeLoanBookButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.metroPanel1.TabIndex = 32;
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
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(9, 78);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(121, 19);
            this.metroLabel4.TabIndex = 37;
            this.metroLabel4.Text = "Take Loan For Days";
            // 
            // ReturnedDaysComboBox
            // 
            this.ReturnedDaysComboBox.FormattingEnabled = true;
            this.ReturnedDaysComboBox.ItemHeight = 23;
            this.ReturnedDaysComboBox.Items.AddRange(new object[] {
            "Select Days From List",
            "1 Day",
            "2 Days",
            "7 Days",
            "15 Days",
            "30 Days"});
            this.ReturnedDaysComboBox.Location = new System.Drawing.Point(9, 100);
            this.ReturnedDaysComboBox.Name = "ReturnedDaysComboBox";
            this.ReturnedDaysComboBox.Size = new System.Drawing.Size(450, 29);
            this.ReturnedDaysComboBox.TabIndex = 36;
            this.ReturnedDaysComboBox.UseSelectable = true;
            // 
            // BookComboBox
            // 
            this.BookComboBox.FormattingEnabled = true;
            this.BookComboBox.ItemHeight = 23;
            this.BookComboBox.Location = new System.Drawing.Point(9, 32);
            this.BookComboBox.Name = "BookComboBox";
            this.BookComboBox.Size = new System.Drawing.Size(450, 29);
            this.BookComboBox.TabIndex = 35;
            this.BookComboBox.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(9, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(87, 19);
            this.metroLabel2.TabIndex = 34;
            this.metroLabel2.Text = "Choose Book";
            // 
            // TakeLoanBookButton
            // 
            this.TakeLoanBookButton.Location = new System.Drawing.Point(9, 148);
            this.TakeLoanBookButton.Name = "TakeLoanBookButton";
            this.TakeLoanBookButton.Size = new System.Drawing.Size(120, 34);
            this.TakeLoanBookButton.TabIndex = 38;
            this.TakeLoanBookButton.Text = "Take Loan";
            this.TakeLoanBookButton.UseSelectable = true;
            this.TakeLoanBookButton.Click += new System.EventHandler(this.TakeLoanBookButton_Click);
            // 
            // BorrowBookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TakeLoanBookButton);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.ReturnedDaysComboBox);
            this.Controls.Add(this.BookComboBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "BorrowBookControl";
            this.Size = new System.Drawing.Size(567, 421);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.ListBox ErrorData;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox ReturnedDaysComboBox;
        private MetroFramework.Controls.MetroComboBox BookComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton GiveLoanBookButton;
        private MetroFramework.Controls.MetroButton TakeLoanBookButton;
    }
}
