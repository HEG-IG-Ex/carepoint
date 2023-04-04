using carepoint.business;
using carepoint.PatientSide;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnBook_Click(object sender, EventArgs e)
        {
            FrmSearch search = new FrmSearch();
            //search.MdiParent = Program.container;
            search.ShowDialog();
        }
    }
}
