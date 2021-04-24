
namespace Library_Juggle.Presentation_Layer.Librarian_Controls
{
    partial class AddNewBookControl
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
            this.BookTitle = new System.Windows.Forms.TextBox();
            this.BookAuthor = new System.Windows.Forms.TextBox();
            this.BookPublisher = new System.Windows.Forms.TextBox();
            this.BookPublishDate = new MetroFramework.Controls.MetroDateTime();
            this.BookGenre = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.AddNewBookButton = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.ErrorData = new System.Windows.Forms.ListBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookTitle
            // 
            this.BookTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookTitle.Location = new System.Drawing.Point(9, 34);
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.Size = new System.Drawing.Size(227, 29);
            this.BookTitle.TabIndex = 0;
            // 
            // BookAuthor
            // 
            this.BookAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookAuthor.Location = new System.Drawing.Point(275, 34);
            this.BookAuthor.Name = "BookAuthor";
            this.BookAuthor.Size = new System.Drawing.Size(227, 29);
            this.BookAuthor.TabIndex = 1;
            // 
            // BookPublisher
            // 
            this.BookPublisher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BookPublisher.Location = new System.Drawing.Point(9, 88);
            this.BookPublisher.Name = "BookPublisher";
            this.BookPublisher.Size = new System.Drawing.Size(227, 29);
            this.BookPublisher.TabIndex = 2;
            // 
            // BookPublishDate
            // 
            this.BookPublishDate.CustomFormat = "";
            this.BookPublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BookPublishDate.Location = new System.Drawing.Point(275, 88);
            this.BookPublishDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.BookPublishDate.Name = "BookPublishDate";
            this.BookPublishDate.Size = new System.Drawing.Size(227, 29);
            this.BookPublishDate.TabIndex = 4;
            // 
            // BookGenre
            // 
            this.BookGenre.FormattingEnabled = true;
            this.BookGenre.ItemHeight = 23;
            this.BookGenre.Location = new System.Drawing.Point(9, 142);
            this.BookGenre.Name = "BookGenre";
            this.BookGenre.Size = new System.Drawing.Size(493, 29);
            this.BookGenre.TabIndex = 5;
            this.BookGenre.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Book Title";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(275, 12);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(83, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Book Author";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(9, 66);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(96, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Book Publisher";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(275, 66);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(115, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Book Publish Date";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(9, 120);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Book Genre";
            // 
            // AddNewBookButton
            // 
            this.AddNewBookButton.Location = new System.Drawing.Point(9, 177);
            this.AddNewBookButton.Name = "AddNewBookButton";
            this.AddNewBookButton.Size = new System.Drawing.Size(120, 34);
            this.AddNewBookButton.TabIndex = 11;
            this.AddNewBookButton.Text = "Add New Book";
            this.AddNewBookButton.UseSelectable = true;
            this.AddNewBookButton.Click += new System.EventHandler(this.AddNewBookButton_Click);
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
            this.metroPanel1.TabIndex = 30;
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
            // AddNewBookControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.AddNewBookButton);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BookGenre);
            this.Controls.Add(this.BookPublishDate);
            this.Controls.Add(this.BookPublisher);
            this.Controls.Add(this.BookAuthor);
            this.Controls.Add(this.BookTitle);
            this.Name = "AddNewBookControl";
            this.Size = new System.Drawing.Size(567, 421);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BookTitle;
        private System.Windows.Forms.TextBox BookAuthor;
        private System.Windows.Forms.TextBox BookPublisher;
        private MetroFramework.Controls.MetroDateTime BookPublishDate;
        private MetroFramework.Controls.MetroComboBox BookGenre;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton AddNewBookButton;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.ListBox ErrorData;
    }
}
