﻿using carepoint.domain;
using carepoint.PatientSide;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            this.setMenu();
            dashboard = FrmDashboard.getInstance();
            dashboard.MdiParent = this;
            dashboard.Show();
        }

        private void setMenu()
        {

            switch (Program.CurrentUser)
            {
                case Admin admin:
                    tsmiAdmin.Visible = true;
                    tsmiAvailabilities.Visible = false;
                    tsmiBook.Visible = false;
                    break;
                case Doctor doctor:
                    tsmiAdmin.Visible = false;
                    tsmiAvailabilities.Visible = true;
                    tsmiBook.Visible = false;
                    break;
                case Patient patient:
                    tsmiAdmin.Visible = false;
                    tsmiAvailabilities.Visible = false;
                    tsmiBook.Visible = true;
                    break;
            }
        }

        private void tsmiDashboard_Click(object sender, EventArgs e)
        {
            dashboard = FrmDashboard.getInstance();
            dashboard.MdiParent = this;
            dashboard.Show();
        }

        private void tsmiBook_Click(object sender, EventArgs e)
        {
            FrmSearch search = new FrmSearch();
            search.ShowDialog();
        }

        private void tsmiAvailabilities_Click(object sender, EventArgs e)
        {
            FrmAvailabilities availabilities = new FrmAvailabilities();
            availabilities.ShowDialog();
        }

        private void tsmiModify_Click(object sender, EventArgs e)
        {
            FrmRegister profil = new FrmRegister();
            profil.ShowDialog();

        }
    }
}
