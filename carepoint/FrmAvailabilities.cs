﻿using System;
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
    public partial class FrmAvailabilities : Form
    {
        public FrmAvailabilities()
        {
            InitializeComponent();
            //TODO : Load availabilities saved for the doctors
            //TODO : Load all appointments booked
            //TODO : onChange of any Chk OR Rdo check if impact any future appointment
            //TODO : Avoid no AM/PM selected and Presnet OR AM and/or PM and Absent
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("New availabilities changed", "Availabilities", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
