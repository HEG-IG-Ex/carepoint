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

using carepoint.factory;
using carepoint.domain;

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

            //hash the password

            // QUERY
            //Get the user
            USR_DATA_DATASET ds = new USR_DATA_DATASET();
            USR_DATA_DATASETTableAdapters.CRP_PERSONTableAdapter tableAdapter = new USR_DATA_DATASETTableAdapters.CRP_PERSONTableAdapter();
            DataTable table = tableAdapter.GetByAuthenticate("admin", "86ff11bd7933c00a2aaa8efafa4e5266c45b26b0");
            
             
            // CHECK - Check if there is only one datarow = one user
            if(table.Rows.Count == 1)
            {
                // GRANT - Instantiate user
                DataRow user = table.Rows[0];
                PersonFactory personFactory = PersonFactory.Instance;
                Program.CurrentUser = personFactory.CreateUser((Role)user["per_rol_id"], user);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // DENY
                // if not => DISLAY ERROR
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

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
