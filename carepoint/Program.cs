﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using carepoint.business;

namespace carepoint
{
    internal static class Program
    {
        public static User CurrentUser;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmBoot boot = new FrmBoot();
            DialogResult result = boot.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (boot.IsLogin)
                {
                    Form next = new FrmLogin();
                    result = next.ShowDialog();
                } 
                else
                {
                    Form next = new FrmRegister(false);
                    result = next.ShowDialog();
                }
            }


            if (CurrentUser != null && result == DialogResult.OK)
            {
                Application.Run(new FrmHome());
            }
            
        }
    }
}
