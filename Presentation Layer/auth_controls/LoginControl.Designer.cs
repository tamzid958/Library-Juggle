
namespace Library_Juggle.Presentation_Layer.auth_controls
{
    partial class LoginControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginControl));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SignUpLink = new MetroFramework.Controls.MetroLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.UserPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.UserEmail = new System.Windows.Forms.TextBox();
            this.ErrorData = new System.Windows.Forms.ListBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(499, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 421);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(28, 217);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(146, 19);
            this.metroLabel1.TabIndex = 14;
            this.metroLabel1.Text = "Don\'t have an account? ";
            // 
            // SignUpLink
            // 
            this.SignUpLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SignUpLink.AutoSize = true;
            this.SignUpLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpLink.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.SignUpLink.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.SignUpLink.Location = new System.Drawing.Point(28, 236);
            this.SignUpLink.Name = "SignUpLink";
            this.SignUpLink.Size = new System.Drawing.Size(61, 19);
            this.SignUpLink.TabIndex = 15;
            this.SignUpLink.Text = "Sign Up";
            this.SignUpLink.UseCustomForeColor = true;
            this.SignUpLink.UseStyleColors = true;
            this.SignUpLink.Click += new System.EventHandler(this.SignUpLink_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            // 
            // UserPassword
            // 
            this.UserPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserPassword.Location = new System.Drawing.Point(28, 114);
            this.UserPassword.Name = "UserPassword";
            this.UserPassword.PasswordChar = '*';
            this.UserPassword.Size = new System.Drawing.Size(229, 29);
            this.UserPassword.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Email";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LoginButton.Location = new System.Drawing.Point(28, 164);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(129, 37);
            this.LoginButton.TabIndex = 12;
            this.LoginButton.Text = "Sign In";
            this.LoginButton.UseCustomBackColor = true;
            this.LoginButton.UseCustomForeColor = true;
            this.LoginButton.UseSelectable = true;
            this.LoginButton.UseStyleColors = true;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UserEmail
            // 
            this.UserEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserEmail.Location = new System.Drawing.Point(28, 56);
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.Size = new System.Drawing.Size(227, 29);
            this.UserEmail.TabIndex = 8;
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
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.ErrorData);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 369);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(499, 52);
            this.metroPanel1.TabIndex = 29;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UserEmail);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignUpLink);
            this.Controls.Add(this.UserPassword);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(767, 421);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel SignUpLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserPassword;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton LoginButton;
        private System.Windows.Forms.TextBox UserEmail;
        private System.Windows.Forms.ListBox ErrorData;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}
