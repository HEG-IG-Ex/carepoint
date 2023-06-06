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

        private void populateNextAppointment()
        {
            switch (Program.CurrentUser)
            {
                case Doctor doctor:
                    populateNextAppointmentForDoctors();
                    break;

                case Patient patient:
                    populateNextAppointmentForPatient();
                    break;

            }
        }
        private void populatePastAppointment()
        {
            switch (Program.CurrentUser)
            {
                case Doctor doctor:
                    populatePastAppointmentForDoctors();
                    break;

                case Patient patient:
                    populatePastAppointmentForPatient();
                    break;

            }
        }


        private void populateNextAppointmentForDoctors()
        {
            USR_DATA_DATASETTableAdapters.VW_DOCTORS_APPTableAdapter docAppTableAdapter = new USR_DATA_DATASETTableAdapters.VW_DOCTORS_APPTableAdapter();
            DataTable table = docAppTableAdapter.GetNextAppByDocId(Program.CurrentUser.id);
            dgvNextApp.DataSource = table;
            dgvNextApp.Columns["APP_ID"].Visible = false;
        }

        private void populatePastAppointmentForDoctors()
        {
            USR_DATA_DATASETTableAdapters.VW_DOCTORS_APPTableAdapter docAppTableAdapter = new USR_DATA_DATASETTableAdapters.VW_DOCTORS_APPTableAdapter();
            DataTable table = docAppTableAdapter.GetPastAppByDocId(Program.CurrentUser.id);
            dgvPastApp.DataSource = table;
            dgvPastApp.Columns["APP_ID"].Visible = false;
        }

        private void populateNextAppointmentForPatient()
        {
            USR_DATA_DATASETTableAdapters.VW_PATIENTS_APPTableAdapter patAppTableAdapter = new USR_DATA_DATASETTableAdapters.VW_PATIENTS_APPTableAdapter();
            DataTable table = patAppTableAdapter.GetNextAppByPatId(Program.CurrentUser.id);
            dgvNextApp.DataSource = table;
            dgvNextApp.Columns["APP_ID"].Visible = false;
        }

        private void populatePastAppointmentForPatient()
        {
            USR_DATA_DATASETTableAdapters.VW_PATIENTS_APPTableAdapter patAppTableAdapter = new USR_DATA_DATASETTableAdapters.VW_PATIENTS_APPTableAdapter();
            DataTable table = patAppTableAdapter.GetPastAppByPatId(Program.CurrentUser.id);
            dgvPastApp.DataSource = table;
            dgvPastApp.Columns["APP_ID"].Visible = false;
        }

        private void setupDataGridView()
        {
            populateNextAppointment();
            populatePastAppointment();
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

        /*private void dgvNextApp_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex > -1 && e.ColumnIndex > -1)
                {
                    DataGridViewCell cell = (sender as DataGridView)[e.ColumnIndex, e.RowIndex];
                    cmsApp.Show(cell.DataGridView, PointToClient(Cursor.Position));
                    if (!cell.Selected)
                    {
                        cell.DataGridView.ClearSelection();
                        cell.DataGridView.CurrentCell = cell;
                        cell.Selected = true;
                    }
                }
            }
        }*/

        private void dgvNextApp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dgvNextApp.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0 && hitTestInfo.ColumnIndex >= 0)
                {
                    dgvNextApp.ClearSelection();
                    dgvNextApp.Rows[hitTestInfo.RowIndex].Selected = true;

                    DataGridViewRow selectedRow = dgvNextApp.Rows[hitTestInfo.RowIndex];
                    DataGridViewCell clickedCell = selectedRow.Cells[hitTestInfo.ColumnIndex];

                    Point cellPosition = dgvNextApp.PointToScreen(clickedCell.ContentBounds.Location);

                    cmsApp.Show(cellPosition);
                }
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
            //search.MdiParent = Program.container;
            search.ShowDialog();
            if(search.DialogResult == DialogResult.OK)
            {
                this.populateNextAppointment();
            }
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            //FrmAppointment appointment = new FrmAppointment();
            //appointment.ShowDialog();
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
                    DataAccessLayer.getInstance.cancelAppointment(Convert.ToInt16(selectedRow.Cells[0].Value), reason);
                }
            }   
        }
    }

}
