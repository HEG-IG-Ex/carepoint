using carepoint.dao;
using carepoint.domain;
using carepoint.Properties;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace carepoint
{
    public partial class FrmAppointment : Form
    {
        private Appointment appointment;
        private actionTypes actionType { get; set; }

        public FrmAppointment(Appointment app, actionTypes actionType)
        {
            InitializeComponent();
            appointment = app;
            lblDate.Text = appointment.appointmentDate.Date.ToString();
            lblHours.Text = appointment.appointmentDate.TimeOfDay.ToString();
            lblDoctor.Text = "Dr " + appointment.doctor.firsname + " " + appointment.doctor.lastname;
            lblSpecialty.Text = appointment.doctor.specialty.name;
            txtDescription.Text = appointment.desc;

            this.actionType = actionType;
            btnConfirm.Text = actionType == actionTypes.Create ? "Create" : "Close";

            paintStatus();

            loadServices();
            loadMedications();
            loadServicesProvided();
            loadPrescriptions();
            switchState(Program.CurrentUser is Doctor, true);
        }

        private void loadServicesProvided()
        {
            dgvServices.DataSource = DataAccessLayer.getInstance.getServicesProvided(appointment.id);
            dgvServices.Columns["APP_ID"].Visible = false;
        }

        private void loadPrescriptions()
        {
            dgvMedications.DataSource = DataAccessLayer.getInstance.getPrescriptions(appointment.id);
            dgvMedications.Columns["PRE_APP_ID"].Visible = false;
            dgvMedications.Columns["PRE_MED_ID"].Visible = false;
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
            if(actionType == actionTypes.Create)
            {
                DialogResult res = MessageBox.Show("Confirm Appointment ?", "Do you want to book this Appointment ?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Yes)
                {
                    appointment.desc = txtDescription.Text;
                    if (DataAccessLayer.getInstance.createNewAppointment(appointment))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error when creation a Appointment", "Impossible to create this appointment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if(actionType == actionTypes.Update)
            {
                    appointment.desc = txtDescription.Text;
                    if (DataAccessLayer.getInstance.updateDesc(appointment.desc, appointment.id))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error when updating an Appointment", "Impossible to update this appointment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void switchState(Boolean isDoctor, Boolean isEnable)
        {
            txtDescription.Enabled = isEnable;
            picPrescription.Visible = appointment.getStatus() == Appointment.Status.INVOICED;
            picInvoice.Visible = appointment.getStatus() == Appointment.Status.INVOICED;
            dgvMedications.ClearSelection();
            dgvServices.ClearSelection();

            if (isDoctor)
            {
                // Medications
                dgvMedications.Enabled = isEnable;
                cboMedications.Enabled = isEnable;
                picAddMed.Visible = isEnable;
                picSearchMedication.Visible = isEnable;

                // Services
                cboServices.Enabled = isEnable;
                dgvServices.Enabled = isEnable;
                picAddService.Visible = isEnable;
                picSearchService.Visible = isEnable;


                // Status
                picClosed.Visible = isEnable;
                picCancelled.Visible = isEnable;
                btnReopen.Visible = !isEnable;
            }
            else
            {
                // Medications
                dgvMedications.Enabled = false;
                cboMedications.Enabled = false;
                picAddMed.Visible = false;
                picSearchMedication.Visible = false;

                // Services
                cboServices.Enabled = false;
                dgvServices.Enabled = false;
                picAddService.Visible = false;
                picSearchService.Visible = false;


                // Status
                picClosed.Visible = false;
                picCancelled.Visible = false;
                btnReopen.Visible = false;
            }
           
                      
        }

        private void paintStatus()
        {
            switch (appointment.getStatus())
            {
                case Appointment.Status.OPEN:
                    lblStatus.Text = "OPEN";
                    lblStatus.BackColor = Color.FromArgb(0, 0, 186);
                    lblStatus.ForeColor = Color.White;
                    break;

                case Appointment.Status.CANCELLED:
                    lblStatus.Text = "CANCELLED";
                    lblStatus.BackColor = Color.FromArgb(226, 27, 27);
                    lblStatus.ForeColor = Color.White;
                    break;

                case Appointment.Status.INVOICED:
                    lblStatus.Text = "CLOSED";
                    lblStatus.BackColor = Color.FromArgb(0, 186, 0);
                    lblStatus.ForeColor = Color.White;
                    break;
            }
        }

        private void btnReopen_Click(object sender, EventArgs e)
        {
            // Check if is invoiced
            //  -If yes, can't repoen
            //  -If no, clear cancel data
            switchState(Program.CurrentUser is Doctor, true);
            paintStatus();
        }

        private void picClosed_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to close this Appointment and invoice all services ?", "Close Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {
                if (generateInvoice())
                {
                    DataAccessLayer.getInstance.closeAppointment(appointment.id);
                    switchState(Program.CurrentUser is Doctor, false);
                    paintStatus();
                }
            }
        }

        private Boolean generateInvoice()
        {
            Boolean result = false;
            try
            {
                DataTable invoice = DataAccessLayer.getInstance.getInvoice(appointment.id);
                // Path to the directory where the file will be saved
                string directoryPath = "./Output/Invoices";

                // Create the directory if it doesn't exist
                Directory.CreateDirectory(directoryPath);

                // Path to the output file
                string invoiceNumber = generateInvoiceNumber();
                string filePath = Path.Combine(directoryPath, $"{invoiceNumber}.xml");


                // Write the DataTable to an XML file
                invoice.WriteXml(filePath, XmlWriteMode.WriteSchema);

                // Display a message to indicate the file has been saved
                Console.WriteLine("Invoices have been saved to the file: " + filePath);
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating appointment: " + ex.Message);
                
            }

            return result;
        }

        private string generateInvoiceNumber()
        {
            Random random = new Random();
            int invoiceNumber = random.Next(100000, 999999); // Generate a random number between 100000 and 999999

            return invoiceNumber.ToString("D6"); // Convert the number to a 6-digit string with leading zeros if necessary
        }

        private void picCancelled_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to cancel this Appointment ?", "Cancel Appointment", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (res == DialogResult.Yes)
            {      
                string reason = Microsoft.VisualBasic.Interaction.InputBox("Enter cancellation reason:", "Cancellation Reason", "");

                // Update cancel data
                DataAccessLayer.getInstance.cancelAppointment(appointment.id, reason);

                switchState(Program.CurrentUser is Doctor, false);
                paintStatus();
            }
        }

        private void picAddService_Click(object sender, EventArgs e)
        {
            DataRowView vrow = (DataRowView)cboServices.SelectedItem;
            if(vrow != null)
            {
                DataRow row = vrow.Row;

                int duration = Convert.ToInt16(row["SER_INV_ID"]) == 1 ? GetNumericInput("Enter a duration value:") : 1;

                // Retrieve the ValueMember property of the selected item
                string code = cboServices.SelectedValue.ToString();

                if (duration > 0)
                {
                    if (DataAccessLayer.getInstance.addServices(appointment.id, code, duration))
                    {
                        loadServicesProvided();
                    }
                }
            }

        }

        private void picAddMed_Click(object sender, EventArgs e)
        {
            DataRowView vrow = (DataRowView)cboMedications.SelectedItem;
            if (vrow != null)
            {
                DataRow row = vrow.Row;
                int medId = Convert.ToInt16(row["MED_ID"]);
                string prescription = Microsoft.VisualBasic.Interaction.InputBox("Capture the details of your prescription", "Prescription");
                
                if (DataAccessLayer.getInstance.addPrescription(appointment.id, medId, prescription))
                {
                    loadPrescriptions();
                }
            }
        }


        static int GetNumericInput(string prompt)
        {
            int numericValue;

            while (true)
            {
                string userInput = Microsoft.VisualBasic.Interaction.InputBox(prompt, "Durationt");
                
                if (string.IsNullOrEmpty(userInput))
                {
                    // User clicked on "Cancel", set the flag and break out of the loop
                    numericValue = -1;
                    break;
                }
                if (int.TryParse(userInput, out numericValue))
                {
                    // Input is a valid integer, break out of the loop
                    break;
                }
                else
                {
                    // Input is not a valid integer, display an error message
                    MessageBox.Show("Invalid input! Please enter a numeric value.", "Error");
                }
            }

            return numericValue;
        }

        private void tsmiCancel_Click(object sender, EventArgs e)
        {
            // Get the selected row
            if (dgvServices.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvServices.SelectedRows[0];
                int id = Convert.ToInt16(selectedRow.Cells[0].Value);
                string code = selectedRow.Cells[1].Value.ToString();
                if (DataAccessLayer.getInstance.removeServices(id, code))
                {
                    dgvServices.DataSource = DataAccessLayer.getInstance.getServicesProvided(id);
                }
            }

        }

        private void tsmiCancelPresc_Click(object sender, EventArgs e)
        {
            // Get the selected row
            if (dgvMedications.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvMedications.SelectedRows[0];
                int appId = Convert.ToInt16(selectedRow.Cells[0].Value);
                int medId = Convert.ToInt16(selectedRow.Cells[1].Value);
                if (DataAccessLayer.getInstance.removePrescription(appId, medId))
                {
                    dgvMedications.DataSource = DataAccessLayer.getInstance.getPrescriptions(appId);
                }
            }
        }
    }
}
