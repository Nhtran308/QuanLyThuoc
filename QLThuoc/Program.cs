using QLThuoc.Util;
using QLThuoc.View;

namespace QLThuoc
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataHelper.server = "localhost";
            DataHelper.data = "demo";
            DataHelper.uid = "sa";
            DataHelper.password = "Abcdef@123";

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMenu());
        }
    }
}