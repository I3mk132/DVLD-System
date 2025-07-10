using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace Presentation_Layer
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new frmHomePage());
            //while (true)
            //{
            //    // show the login form
            //    frmLogin loginForm = new frmLogin();
            //    Application.Run(loginForm);

            //    if (clsGlobal.CurrentUser != null)
            //    {
            //        frmHomePage homePage = new frmHomePage();
            //        Application.Run(homePage);

            //        if (homePage.logoutFlag)
            //        {
            //            clsGlobal.CurrentUser = null;
            //            continue;
            //        }
            //    }

            //    break;
            //}


        }
    }
}
