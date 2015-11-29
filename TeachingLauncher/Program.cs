using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace TeachingLauncher
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
            string strAppPath = Path.GetDirectoryName(Application.ExecutablePath);
            if (!strAppPath.EndsWith("\\"))
                strAppPath += "\\";
            strAppPath += "App\\Teaching.exe";
            if (File.Exists(strAppPath))
                Process.Start(strAppPath);
            else
                MessageBox.Show("The application is not installed properly. Please re-install it.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
