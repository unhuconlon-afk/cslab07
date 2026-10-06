using System;
using System.Windows.Forms;

namespace Lab09_QuanLyBanHang
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
            Application.Run(new frmBanHang());
        }    
    }
}