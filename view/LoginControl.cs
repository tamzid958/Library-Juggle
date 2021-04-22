using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;


namespace Library_Juggle.view
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void SignUpLink_Click(object sender, EventArgs e)
        {
            RegisterControl register = new();
            this.Hide();
            this.Parent.Controls.Add(register);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
          
        }
    }
}
