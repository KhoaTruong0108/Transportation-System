using System;
using System.Windows.Forms;

namespace Staff
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
            Application.Run(new Main());
            //using (LoginClient frmLogin = new LoginClient(Constants.UserRole.Staff))
            //{
            //    if (frmLogin.ShowDialog().Equals(DialogResult.OK))
            //    {
            //        Application.Run(new Main());
            //    }
            //    else
            //    {
            //        Application.Exit();
            //    }
            //}
        }
    }
}
