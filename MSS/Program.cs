using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSS
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
            //Application.Run(new DumpData());
            //Application.Run(new frmDashboard());
            //Application.Run(new ReportPatientReg());
            Application.Run(new Login());
            Application.Run(new MDIMainForm());

        }
    }
}
