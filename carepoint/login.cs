using carepoint.business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carepoint
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {   

            if(!string.IsNullOrWhiteSpace(txt_psw.Text) && 
                !string.IsNullOrWhiteSpace(txt_username.Text))
            {
                Program.CurrentUser = new User(txt_psw.Text, txt_username.Text);
            }

            if(Program.CurrentUser != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();

            } else
            {
                MessageBox.Show("Login Error", "Username OR Password incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_username.Clear();
                this.txt_psw.Clear();
            }
        }
    }
}
