using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TeachingUpdater
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                if (args.Count() != 2)
                    return;
                else
                {
                    string strCurrentVersion = args[0];
                    string strConsiderBetas = args[1];

                    Application.Run(new B(args[0], Convert.ToBoolean(args[1])));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error starting the Teaching App Updater: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
