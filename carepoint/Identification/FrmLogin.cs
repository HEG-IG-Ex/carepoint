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
using Microsoft.VisualBasic;

namespace carepoint
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {   

            if(!string.IsNullOrWhiteSpace(txtPsw.Text) && 
                !string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                Program.CurrentUser = new User(txtPsw.Text, txtUsername.Text);
            }

            if(Program.CurrentUser != null)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();

            } else
            {
                MessageBox.Show("Login Error", "Username OR Password incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsername.Clear();
                this.txtPsw.Clear();
            }
        }

        private void llbResetPsw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string resetMail = Interaction.InputBox("Please enter your email", "Reset email", "");
            MessageBox.Show("Temporary password sent to " + resetMail, "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
