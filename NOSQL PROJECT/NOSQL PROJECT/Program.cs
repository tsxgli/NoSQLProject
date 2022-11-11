using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOSQL_PROJECT
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
           
            Employee em
                = new Employee();
            Application.Run(new MainForm(em));
=======
            Application.Run(new LoginForm());
>>>>>>> parent of d00917e (Merge branch 'Trying-to-merge-with-jo-new-code' into RARES)
        }
    }
}
