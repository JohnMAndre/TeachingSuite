using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdaterReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will do one very simple task
            // It will accept a source and destination filename, then move the source to the destination (overwriting the destination), then relaunch the destination
            // This should be on a delay to give time for the updater to close down
            string strLogfile = args[0];

            try
            {
                System.Threading.Thread.Sleep(2500); // 2.5 seconds should be plenty of time for the caller to shut down

                string strSource = args[1];
                string strDestination = args[2];
                string strCallbackParms = args[3];

                
                System.Threading.Thread.Sleep(1500);

                if (System.IO.File.Exists(strLogfile))
                    System.IO.File.AppendAllText(strLogfile, "UpdaterReplacer Replaced updater: Source: " + strSource + "; Destination: " + strDestination + Environment.NewLine);

                System.Diagnostics.Process.Start(strDestination);

                if (System.IO.File.Exists(strLogfile))
                    System.IO.File.AppendAllText(strLogfile, "UpdaterReplacer Launched: " + strDestination + Environment.NewLine);
         
            }
            catch (Exception ex)
            {
                if (System.IO.File.Exists(strLogfile))
                    System.IO.File.AppendAllText(strLogfile, "UpdaterReplacer Error: " + ex.Message + Environment.NewLine);
                Console.WriteLine("There was an error: " + ex.Message);
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
            }

        }
    }
}
