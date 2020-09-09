using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using testePratico.Admin;

namespace testePratico
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin Tela_Login = new frmLogin();

            if (Tela_Login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmPrincipal());
            }
        }
    }
}
