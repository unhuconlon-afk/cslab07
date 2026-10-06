using System;
using System.Windows.Forms;

namespace cslab07_Launcher
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLauncher());
        }    
    }
}