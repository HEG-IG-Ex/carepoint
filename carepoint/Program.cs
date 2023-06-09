﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using carepoint.domain;
using static System.Net.Mime.MediaTypeNames;

namespace carepoint
{
    internal static class Program
    {
        public static Person CurrentUser;
        public static FrmMdi container;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

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
                    Form next = new FrmRegister();
                    result = next.ShowDialog();

                    if(next.DialogResult == DialogResult.OK)
                    {
                        next = new FrmLogin();
                        result = next.ShowDialog();
                    }

                }
                
            }


            if (CurrentUser != null && result == DialogResult.OK)
            {
                container = new FrmMdi();
                System.Windows.Forms.Application.Run(container);
            }
            
        }
    }
}
