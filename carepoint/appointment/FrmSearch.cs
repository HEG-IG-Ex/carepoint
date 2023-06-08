using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using carepoint.domain;
using carepoint.factory;
using carepoint.dao;

namespace carepoint.PatientSide
{
    public partial class FrmSearch : Form
    {
        public FrmSearch()
        {
            InitializeComponent();
            setTooltip();
        }

        private void setTooltip()
        {
            // Create the ToolTip and associate with the Form container.
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.picBook, "Book this appointment");
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void picBook_Click(object sender, EventArgs e)
        {       
            if(dgvNextAvailabilities.DataSource != null && dgvNextAvailabilities.SelectedRows.Count > 0 && rdoDoctor.Checked)
            {
               
                FrmAppointment frmAppointment = new FrmAppointment(convertResearchIntoAppointmentToCreate(), actionTypes.Create);
                frmAppointment.ShowDialog();

                if (frmAppointment.DialogResult == DialogResult.OK) 
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    
                }
            }

        }

        private Appointment convertResearchIntoAppointmentToCreate()
        {
            DataRowView vrow = (DataRowView)cboCriteriaList.SelectedItem;
            DataRow row = vrow.Row;

            Doctor doc = PersonFactory.getInstance.createDoctor(row);

            DataGridViewRow dgvRow = dgvNextAvailabilities.SelectedRows[0];


            DateTime date = Convert.ToDateTime(dgvRow.Cells[0].Value);
            TimeSpan hours = TimeSpan.Parse(dgvRow.Cells[1].Value.ToString());

            DateTime mergedDateTime = date.Date + hours;

            return new Appointment(mergedDateTime, (Patient)Program.CurrentUser, doc);
        }

        private void rdoDoctor_CheckedChanged(object sender, EventArgs e)
        {
            // Handle the event when the radio button selection changes
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                // Perform actions based on the selected radio button
                // You can access the properties of the selected radio button using 'radioButton'
                loadDoctorsList();

            }
        }


        private void rdoSpecialty_CheckedChanged(object sender, EventArgs e)
        {
            // Handle the event when the radio button selection changes
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                // Perform actions based on the selected radio button
                // You can access the properties of the selected radio button using 'radioButton'
                loadSpecialty();

            }
        }

        private void loadDoctorsList()
        {
            cboCriteriaList.DataSource = DataAccessLayer.getInstance.getDoctorsAsCriteriaList();
            cboCriteriaList.DisplayMember = "fullname";
            cboCriteriaList.ValueMember = "PER_ID";
            cboCriteriaList.SelectedIndex = -1;
        }


        private void loadSpecialty()
        {

            cboCriteriaList.DataSource = DataAccessLayer.getInstance.getSpecialtyAsCriteriaList();
            cboCriteriaList.DisplayMember = "SPE_NAME";
            cboCriteriaList.ValueMember = "SPE_ID";
            cboCriteriaList.SelectedIndex = -1;
        }

        private void cboCriteriaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender; // Cast the sender to ComboBox

            // Retrieve the selected value
            object selectedValue = comboBox.SelectedValue;

            // Check if the selected value is not null and can be converted to an integer
            if (selectedValue != null && int.TryParse(selectedValue.ToString(), out int id))
            {
                dgvNextAvailabilities.DataSource = DataAccessLayer.getInstance.getNextAvailabilities(rdoDoctor.Checked, id);
                dgvNextAvailabilities.BackgroundColor = Color.White;
                dgvNextAvailabilities.RowHeadersVisible = false;
            }
        }
    }
}
