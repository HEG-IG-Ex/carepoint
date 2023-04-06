using carepoint.business;
using carepoint.PatientSide;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

            // This is test data for prototyppe purpose
            setupDataGridView(dgvNextApp);
            setupDataGridView(dgvPastApp);
            populateDataGridViewNextApp(dgvNextApp);
            populateDataGridViewNextApp(dgvPastApp);
            createCancelColumn();


            lblWelcome.Text = "Welcome " + Program.CurrentUser.username.ToUpper() + "!";

            //ToolStripMenuItem menuItem = MainMenu.Items[mnItm] as ToolStripMenuItem;

            // TODO: Header will change according to role
            headersNextApp = new List<string>() { "id", "Date", "Hour", "Doctor", "Description", "Cancel"};
            headersPastApp = new List<string>() { "id", "Date", "Hour", "Doctor", "Description", "Invoice", "Prescription" };

            
        }

        static public FrmDashboard getInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FrmDashboard();
            }
            return instance;
        }

        private void setupDataGridView(DataGridView dgv)
        {
            dgv.ColumnCount = 6;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgvNextApp.Font, FontStyle.Bold);
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgv.GridColor = Color.Black;
            dgv.RowHeadersVisible = false;


            dgv.Columns[0].Name = "id";
            dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns[1].Name = "Date";
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns[2].Name = "Hour";
            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns[3].Name = "Doctor";
            dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns[4].Name = "Description";
            dgv.Columns[4].DefaultCellStyle.Font = new Font(dgvNextApp.DefaultCellStyle.Font, FontStyle.Italic);

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.Dock = DockStyle.Fill;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void populateDataGridViewNextApp(DataGridView dgv)
        {
            //"id", "Date", "Hour", "Doctor", "Description", "Cancel"
            string[] row0 = { "1", "01/01/2023", "11:00", "Dr. Daniels", "Test"};
            string[] row1 = { "2", "01/02/2023", "12:00", "Dr. Bowden", "Test"};
            string[] row2 = { "3", "01/03/2023", "13:00", "Dr. Cappa", "Test"};
            string[] row3 = { "4", "01/04/2023", "14:00", "Dr. McKenna", "Test"};
            string[] row4 = { "5", "01/05/2023", "15:00", "Dr. Dignam", "Test"};
            string[] row5 = { "6", "01/06/2023", "16:00", "Dr. Cutting", "Test"};
            string[] row6 = { "7", "01/07/2023", "17:00", "Dr. Cady", "Test" };

            dgv.Rows.Add(row0);
            dgv.Rows.Add(row1);
            dgv.Rows.Add(row2);
            dgv.Rows.Add(row3);
            dgv.Rows.Add(row4);
            dgv.Rows.Add(row5);
            dgv.Rows.Add(row6);

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            FrmSearch search = new FrmSearch();
            //search.MdiParent = Program.container;
            search.ShowDialog();
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
    }
}
