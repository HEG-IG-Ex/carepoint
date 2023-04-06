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
    public partial class FrmBoot : Form
    {
        private string nextAction; 
        public Boolean IsLogin{
           get { return nextAction == "login"; }        
        }

        public FrmBoot()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.nextAction = "login";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.nextAction = "register";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
