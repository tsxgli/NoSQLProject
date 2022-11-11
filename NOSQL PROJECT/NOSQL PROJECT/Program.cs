using MODEL;
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
            Employee test = new Employee();
            test.UserType = UserType.Regular;
            test.Email = "josianne.mckenzie@schroeder.biz";

            Application.Run(new LoginForm());
        }
    }
}
