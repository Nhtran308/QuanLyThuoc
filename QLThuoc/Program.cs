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
            DataHelper.server = "NHAT\\SQLEXPRESS";
            DataHelper.data = "QuanLyThuoc";
            DataHelper.uid = "NhatTran";
            DataHelper.password = "12345";

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMenu());
        }
    }
}