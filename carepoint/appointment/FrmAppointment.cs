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
    public partial class FrmAppointment : Form
    {
        public FrmAppointment()
        {
            InitializeComponent();
            changeFormStatus(true);
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

        private void changeFormStatus(Boolean isEnable)
        {
            txtDescription.Enabled = isEnable;

            Boolean hasRwRights = (Program.CurrentUser.role == Role.Doctor);

            Boolean isUsable = isEnable & hasRwRights;

            // Medications
            lsbMedications.Enabled = isUsable;
            cboMedications.Enabled = isUsable;
            picAddMed.Visible = isUsable;
            picSearchMedication.Visible = isUsable;
            picPrescription.Visible = !isEnable;
            

            // Services
            cboServices.Enabled = isUsable;
            lsbServices.Enabled = isUsable;
            picAddService.Visible = isUsable;
            picSearchService.Visible = isUsable;
            picInvoice.Visible = !isEnable;
            

            // Status
            picClosed.Visible = isUsable;
            picCancelled.Visible = isUsable;
            btnReopen.Visible = !isEnable;
                      
        }

        private void btnReopen_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "OPEN";
            lblStatus.BackColor = Color.FromArgb(0, 0, 186);
            lblStatus.ForeColor = Color.White;
            changeFormStatus(true);
        }

        private void picClosed_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Close Appointment ?", "Do you want to close this Appointment ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                lblStatus.Text = "CLOSED";
                lblStatus.BackColor = Color.FromArgb(0, 186, 0);
                lblStatus.ForeColor = Color.White;
                changeFormStatus(false);
            }
        }

        private void picCancelled_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Cancel Appointment ?", "Do you want to cancel this Appointment ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                lblStatus.Text = "CANCELLED";
                lblStatus.BackColor = Color.FromArgb(226, 27, 27);
                lblStatus.ForeColor = Color.White;
                changeFormStatus(false);
            }
        }
    }
}
