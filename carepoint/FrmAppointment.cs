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
    public partial class FrmAppointment : Form
    {
        public FrmAppointment()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirm Appointment ?", "Do you want to book this Appointment ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.None;
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Close Appointment ?", "Do you want to close this Appointment ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if(res == DialogResult.Yes)
            {
                lblStatus.Text = "CLOSED";
                changeFormStatus(false);
            }   
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Cancel Appointment ?", "Do you want to cancel this Appointment ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                lblStatus.Text = "CANCELLED";
                changeFormStatus(false);
            }
        }

        private void btnReopen_Click(object sender, EventArgs e)
        {
            changeFormStatus(true);
        }

        private void changeFormStatus(Boolean isEnable)
        {
            txtDescription.Enabled = isEnable;
            txtSearchMedications.Enabled = isEnable;
            txtSearchServices.Enabled = isEnable;
            cklMedications.Enabled = isEnable;
            cklServices.Enabled = isEnable;
            btnCloseApp.Visible = isEnable;
            btnCancel.Visible = isEnable;

            btnReopen.Visible = !isEnable;
            btnPrescription.Visible = !isEnable;
            btnInvoice.Visible = !isEnable;
        }

    }
}
