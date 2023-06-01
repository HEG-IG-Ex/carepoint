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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography;

namespace carepoint
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private Boolean credentialsAreCaptured()
        {
            return !string.IsNullOrEmpty(this.txtUsername.Text) && !string.IsNullOrEmpty(this.txtPsw.Text);
        }

        public static string HashCode(string str)
        {
            System.Text.ASCIIEncoding encoder = new System.Text.ASCIIEncoding();
            byte[] buffer = encoder.GetBytes(str);
            SHA1CryptoServiceProvider cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
            string hash = BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "").ToLower();

            return hash;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //Validate Data
            //if(credentialsAreCaptured())
            //{
                //hash the password
                String usrname = txtUsername.Text;
                String hash = HashCode(this.txtPsw.Text);


                // QUERY
                //Get the user role
                USR_DATA_DATASETTableAdapters.CRP_PERSONTableAdapter personTableAdapter = new USR_DATA_DATASETTableAdapters.CRP_PERSONTableAdapter();
                //DataTable table = personTableAdapter.GetByAuthenticate(usrname, hash);
                DataTable table = personTableAdapter.GetByAuthenticate("julia.miller", "b1b0b8de8a6228f6501c0560365d3a7d74ffcd8e");
                //"admin", "86ff11bd7933c00a2aaa8efafa4e5266c45b26b0"
                //"emilie.schmid", "1f0160076c9f42a157f0a8f0dcc68e02ff69045b"
                //"julia.miller", "b1b0b8de8a6228f6501c0560365d3a7d74ffcd8e"

                // CHECK - Check if there is only one datarow = one user
                if (table.Rows.Count == 1)
                {
                    

                    // GRANT - Instantiate chek records
                    DataRow person = table.Rows[0];

                    // Instantiate Person factory
                    PersonFactory personFactory = PersonFactory.Instance;
                    Program.CurrentUser = personFactory.CreatePerson(person);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                /*}
                else
                {
                    // DENY
                    // if not => DISLAY ERROR
                    MessageBox.Show("Login Error", "Username OR Password incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtUsername.Clear();
                    this.txtPsw.Clear();
                }*/
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
