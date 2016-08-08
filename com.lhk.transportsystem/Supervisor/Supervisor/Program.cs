using System;
using System.Windows.Forms;
using AppCommon.CommonView;
using AppCommon.Constant;
using AppCommon.Util;

namespace Supervisor
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
            using (Login frmLogin = new Login(Constants.UserRole.Supervisor))
            {
                if (frmLogin.ShowDialog().Equals(DialogResult.OK))
                {
                    Application.Run(new Main.Main());
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
