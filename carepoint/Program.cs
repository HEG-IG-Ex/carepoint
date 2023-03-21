using System;
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

            if (CurrentUser == null)
            {
                frmLogin login = new frmLogin();
                DialogResult result = login.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Application.Run(new mdiHome());
                }
            }
            
        }
    }
}
