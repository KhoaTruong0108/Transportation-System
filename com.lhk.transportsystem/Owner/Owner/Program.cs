using System;
using System.Windows.Forms;
using AppCommon.CommonView;
using AppCommon.Constant;

namespace Owner
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
            using (Login frmLogin = new Login(Constants.UserRole.Owner))
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
