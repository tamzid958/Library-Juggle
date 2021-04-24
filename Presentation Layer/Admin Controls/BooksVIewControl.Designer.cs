
namespace Library_Juggle.Presentation_Layer.Admin_Controls
{
    partial class BooksViewControl
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
            this.BookGridView = new MetroFramework.Controls.MetroGrid();
            this.SearchBookTerm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BookGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BookGridView
            // 
            this.BookGridView.AllowUserToResizeRows = false;
            this.BookGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BookGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BookGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.BookGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.BookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BookGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.BookGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BookGridView.EnableHeadersVisualStyles = false;
            this.BookGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BookGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BookGridView.Location = new System.Drawing.Point(0, 140);
            this.BookGridView.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.BookGridView.Name = "BookGridView";
            this.BookGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.BookGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BookGridView.RowTemplate.Height = 25;
            this.BookGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookGridView.Size = new System.Drawing.Size(567, 281);
            this.BookGridView.Style = MetroFramework.MetroColorStyle.Lime;
            this.BookGridView.TabIndex = 0;
            this.BookGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookGridView_CellContentClick);
            this.BookGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.BookGridView_CellValueChanged);
            // 
            // SearchBookTerm
            // 
            this.SearchBookTerm.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchBookTerm.Location = new System.Drawing.Point(0, 0);
            this.SearchBookTerm.Name = "SearchBookTerm";
            this.SearchBookTerm.Size = new System.Drawing.Size(567, 23);
            this.SearchBookTerm.TabIndex = 1;
            this.SearchBookTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SearchBookTerm.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchBookTerm_KeyUp);
            // 
            // BooksViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SearchBookTerm);
            this.Controls.Add(this.BookGridView);
            this.Name = "BooksViewControl";
            this.Size = new System.Drawing.Size(567, 421);
            ((System.ComponentModel.ISupportInitialize)(this.BookGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid BookGridView;
        private System.Windows.Forms.TextBox SearchBookTerm;
    }
}
