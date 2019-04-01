using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Analytica_Lab_Administration_Wizard
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
            Application.Run(new frmDBWizard());
        }
    }
}
