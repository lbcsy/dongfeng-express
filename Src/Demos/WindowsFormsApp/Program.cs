using System;
using DongFeng.Jellyfish;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new AppAssemblyResolveEventHandler("BOOK3:8888/DongFeng-Express").Init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
