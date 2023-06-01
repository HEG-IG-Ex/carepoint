using carepoint.domain;
using carepoint.PatientSide;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace carepoint
{
    public partial class FrmDashboard : Form
    {
        static FrmDashboard instance;

        List<string> headersNextApp;
        List<string> headersPastApp;

        private FrmDashboard()
        {
            InitializeComponent();
            lblUsername.Text = Program.CurrentUser.username.ToUpper();
            setupDataGridView();
            setTooltip();
            picBook.Visible = (Program.CurrentUser is Patient);

            // This is test data for prototyppe purpose
            /*setupDataGridView(dgvNextApp);
            setupDataGridView(dgvPastApp);
            populateDataGridViewNextApp(dgvNextApp);
            populateDataGridViewNextApp(dgvPastApp);
            createCancelColumn();*/



            //ToolStripMenuItem menuItem = MainMenu.Items[mnItm] as ToolStripMenuItem;

            // TODO: Header will change according to role
            /*headersNextApp = new List<string>() { "id", "Date", "Hour", "Doctor", "Description", "Cancel"};
            headersPastApp = new List<string>() { "id", "Date", "Hour", "Doctor", "Description", "Invoice", "Prescription" };
            */


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

        private void dgvNextApp_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
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
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            FrmAppointment appointment = new FrmAppointment();
            appointment.ShowDialog();
        }
    }
}
