using carepoint.dao;
using carepoint.domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace carepoint
{
    public partial class FrmAppointment : Form
    {
        private Appointment appointment;
        private DateTime dt;
        private Doctor doctor;
        private Patient patient;


        public FrmAppointment(DateTime dt, Doctor doc, Boolean isOpenByPatient)
        {
            
            InitializeComponent();
            this.dt = dt;
            this.doctor = doc;

            lblDate.Text = dt.Date.ToString();
            lblHours.Text = dt.TimeOfDay.ToString();
            lblDoctor.Text = "Dr" + doctor.firsname + " " + doctor.lastname;
            lblSpecialty.Text = doctor.specialty.name;
            lblStatus.Text = "OPEN";

            if (isOpenByPatient)
            {
                patient = (Patient) Program.CurrentUser;
            }

            loadServices();
            loadMedications();
            changeFormStatus(isOpenByPatient);
        }

        private void loadServices()
        {
            USR_DATA_DATASETTableAdapters.CRP_SERVICETableAdapter serTableAdapter = new USR_DATA_DATASETTableAdapters.CRP_SERVICETableAdapter();
            DataTable table = serTableAdapter.GetData();
            cboServices.DataSource = table;
            cboServices.DisplayMember = "SER_NAME";
            cboServices.ValueMember = "SER_CODE";
            cboServices.SelectedIndex = -1;
        }

        private void loadMedications()
        {
            USR_DATA_DATASETTableAdapters.CRP_MEDICATIONTableAdapter medTableAdapteer = new USR_DATA_DATASETTableAdapters.CRP_MEDICATIONTableAdapter();
            DataTable table = medTableAdapteer.GetData();
            cboMedications.DataSource = table;
            cboMedications.DisplayMember = "MED_NAME";
            cboMedications.ValueMember = "MED_ID";
            cboMedications.SelectedIndex = -1;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirm Appointment ?", "Do you want to book this Appointment ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                appointment = new Appointment(this.dt, this.patient, this.doctor, txtDescription.Text);
                DataAccessLayer.getInstance.createNewAppointment(appointment);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }else{
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

            Boolean hasRwRights = Program.CurrentUser is Doctor;

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
