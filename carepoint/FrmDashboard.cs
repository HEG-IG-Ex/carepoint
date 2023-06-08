using carepoint.dao;
using carepoint.domain;
using carepoint.PatientSide;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace carepoint
{
    public enum actionTypes
    {
        Create,
        Update,
        Delete
    }

    public partial class FrmDashboard : Form
    {
        static FrmDashboard instance;

        private FrmDashboard()
        {
            InitializeComponent();
            lblUsername.Text = Program.CurrentUser.username.ToUpper();
            setupDataGridView();
            setTooltip();
            picBook.Visible = (Program.CurrentUser is Patient);

         }

        static public FrmDashboard getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmDashboard();
            }
            return instance;
        }

        private void populateAppointments()
        {
            if(Program.CurrentUser is Doctor)
            {
                dgvNextApp.DataSource = DataAccessLayer.getInstance.getNextAppointmentForDoctors(Program.CurrentUser.id);
                dgvPastApp.DataSource = DataAccessLayer.getInstance.getPastAppointmentForDoctors(Program.CurrentUser.id);

            }else if(Program.CurrentUser is Patient)
            {
                dgvNextApp.DataSource = DataAccessLayer.getInstance.getNextAppointmentForPatient(Program.CurrentUser.id);
                dgvPastApp.DataSource = DataAccessLayer.getInstance.getPastAppointmentForPatient(Program.CurrentUser.id); ;
            }

            dgvNextApp.Columns["APP_ID"].Visible = false;
            dgvPastApp.Columns["APP_ID"].Visible = false;
        }

        private void setupDataGridView()
        {
            populateAppointments();
        }

        private void createCancelColumn()
        {
            DataGridViewButtonColumn cnlCol = new DataGridViewButtonColumn();
            cnlCol.Name = "dgc_cnl";
            cnlCol.Text = "Cancel";
            cnlCol.HeaderText = "Cancel";
            cnlCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            int columnIndex = 5;
            if (dgvNextApp.Columns["dgc_cnl"] == null)
            {
                dgvNextApp.Columns.Insert(columnIndex, cnlCol);
            }
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
            toolTip1.SetToolTip(this.picBook, "Book a new appointment");
            //toolTip1.SetToolTip(this.checkBox1, "My checkBox1");
        }

        private void picBook_Click(object sender, EventArgs e)
        {
            FrmSearch search = new FrmSearch();
            search.ShowDialog();
            if(search.DialogResult == DialogResult.OK)
            {
                populateAppointments();
            }
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            // Get the selected row
            if (dgvNextApp.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvNextApp.SelectedRows[0];
                int id = Convert.ToInt16(selectedRow.Cells[0].Value);
                Appointment appointment = DataAccessLayer.getInstance.getAppointmentById(id);

                // Open the form with the selected appointment details
                FrmAppointment frmAppointment = new FrmAppointment(appointment, actionTypes.Update);
                frmAppointment.ShowDialog();
                populateAppointments();
            }
        }

        private void tsmiCancel_Click(object sender, EventArgs e)
        {
            // Get the selected row
            if (dgvNextApp.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvNextApp.SelectedRows[0];
                int id = Convert.ToInt16(selectedRow.Cells[0].Value);
                string reason = Microsoft.VisualBasic.Interaction.InputBox("Enter cancellation reason:", "Cancellation Reason", "");

                if (!string.IsNullOrWhiteSpace(reason))
                {
                    if (DataAccessLayer.getInstance.cancelAppointment(Convert.ToInt16(selectedRow.Cells[0].Value), reason))
                    {
                        populateAppointments();
                    }
                }
            }   
        }

        private void dgvNextApp_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (e.Button == MouseButtons.Right && e.RowIndex != -1)
            {
                var row = dgv.Rows[e.RowIndex];
                dgv.CurrentCell = row.Cells[e.ColumnIndex == -1 ? 1 : e.ColumnIndex];
                row.Selected = true;
                dgv.Focus();
            }
        }



        private void dgvNextApp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                // Get the selected row
                DataRowView selectedRow = (DataRowView)dgvNextApp.Rows[e.RowIndex].DataBoundItem;

                Appointment appointment = DataAccessLayer.getInstance.getAppointmentById(Convert.ToInt32(selectedRow["APP_ID"]));

                // Open the form with the selected appointment details
                FrmAppointment frmAppointment = new FrmAppointment(appointment, actionTypes.Update);
                frmAppointment.ShowDialog();
                populateAppointments();
            }
        }

    }

}
