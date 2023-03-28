using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carepoint
{
    public partial class FrmMdi : Form
    {
        FrmDashboard dashboard;

        public FrmMdi()
        {
            InitializeComponent();
            dashboard = new FrmDashboard(Program.CurrentUser.role);
            dashboard.MdiParent = this;
            dashboard.Show();
        }

        private void tsmiBook_Click(object sender, EventArgs e)
        {
            dashboard = new FrmDashboard(Program.CurrentUser.role);
            dashboard.MdiParent = this;
            dashboard.Show();
        }
    }
}
