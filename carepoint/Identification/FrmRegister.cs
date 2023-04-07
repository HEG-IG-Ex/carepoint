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
    public partial class FrmRegister : Form
    {
        string endMsg = "Registration Complete !";

        public FrmRegister()
        {
            InitializeComponent();
            Boolean isProfil = Program.CurrentUser != null;
            if (isProfil) { 
                Boolean isPatient = (Program.CurrentUser.role == Role.Patient);
                this.grpDoctor.Visible = !isPatient;
                this.grpPatient.Visible = isPatient;
                btnRegister.Text = "Save";
                endMsg = "Modification saved !";
                txtUsername.Text = Program.CurrentUser.username;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show(endMsg, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
