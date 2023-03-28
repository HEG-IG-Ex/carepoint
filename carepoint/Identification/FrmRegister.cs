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
        public FrmRegister(Boolean isPatient)
        {
            InitializeComponent();

            this.grpDoctor.Visible = !isPatient;
            this.grpPatient.Visible = isPatient;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registration Complete !", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
