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
        List<string> headersNextApp;
        List<string> headersPastApp;

        public FrmDashboard(string role)
        {
            InitializeComponent();
            lblWelcome.Text = "Welcome " + Program.CurrentUser.username.ToUpper() + "!";

            // TODO: Header will change according to role
            headersNextApp = new List<string>() { "id", "Date", "Hour", "Doctor", "Description", "Cancel"};
            headersPastApp = new List<string>() { "id", "Date", "Hour", "Doctor", "Description", "Invoice", "Prescription" };

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            FrmSearch search = new FrmSearch();
            search.MdiParent = Program.container;
            search.Show();
        }
    }
}
