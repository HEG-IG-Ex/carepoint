using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            FrmAppointment appointment = new FrmAppointment();
            //appointment.MdiParent = Program.container;
            appointment.ShowDialog();
        }

        private void rdoDoctor_CheckedChanged(object sender, EventArgs e)
        {
            // Handle the event when the radio button selection changes
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                // Perform actions based on the selected radio button
                // You can access the properties of the selected radio button using 'radioButton'
                //USR_DATA_DATASETTableAdapters.VW_DOCTORSTableAdapter doctorsTableAdapter = new USR_DATA_DATASETTableAdapters.VW_DOCTORSTableAdapter();
                //DataTable table = doctorsTableAdapter.GetDoctorsAsCriteriaList();
                //cboCriteriaList.DataSource = table;
                cboCriteriaList.DisplayMember = "fullname";
                cboCriteriaList.ValueMember = "PER_ID";
            }
        }
    }
}
