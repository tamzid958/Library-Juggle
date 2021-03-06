
namespace Library_Juggle.Presentation_Layer.Admin_Controls
{
    partial class GenresViewControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GenreName = new System.Windows.Forms.TextBox();
            this.AddGenreButton = new MetroFramework.Controls.MetroButton();
            this.GenreGridView = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.GenreGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GenreName
            // 
            this.GenreName.Dock = System.Windows.Forms.DockStyle.Top;
            this.GenreName.Location = new System.Drawing.Point(0, 0);
            this.GenreName.Name = "GenreName";
            this.GenreName.Size = new System.Drawing.Size(567, 23);
            this.GenreName.TabIndex = 0;
            // 
            // AddGenreButton
            // 
            this.AddGenreButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddGenreButton.Location = new System.Drawing.Point(0, 23);
            this.AddGenreButton.Name = "AddGenreButton";
            this.AddGenreButton.Size = new System.Drawing.Size(567, 23);
            this.AddGenreButton.TabIndex = 1;
            this.AddGenreButton.Text = "Add Genre";
            this.AddGenreButton.UseSelectable = true;
            this.AddGenreButton.Click += new System.EventHandler(this.AddGenreButton_Click);
            // 
            // GenreGridView
            // 
            this.GenreGridView.AllowUserToAddRows = false;
            this.GenreGridView.AllowUserToResizeRows = false;
            this.GenreGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GenreGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GenreGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GenreGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GenreGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GenreGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GenreGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GenreGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.GenreGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenreGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.GenreGridView.EnableHeadersVisualStyles = false;
            this.GenreGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GenreGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GenreGridView.Location = new System.Drawing.Point(0, 46);
            this.GenreGridView.Name = "GenreGridView";
            this.GenreGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GenreGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GenreGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GenreGridView.RowTemplate.Height = 25;
            this.GenreGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GenreGridView.Size = new System.Drawing.Size(567, 375);
            this.GenreGridView.Style = MetroFramework.MetroColorStyle.Lime;
            this.GenreGridView.TabIndex = 2;
            this.GenreGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GenreGridView_CellContentClick);
            this.GenreGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GenreGridView_CellValueChanged);
            // 
            // GenresViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GenreGridView);
            this.Controls.Add(this.AddGenreButton);
            this.Controls.Add(this.GenreName);
            this.Name = "GenresViewControl";
            this.Size = new System.Drawing.Size(567, 421);
            ((System.ComponentModel.ISupportInitialize)(this.GenreGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GenreName;
        private MetroFramework.Controls.MetroButton AddGenreButton;
        private MetroFramework.Controls.MetroGrid GenreGridView;
    }
}
