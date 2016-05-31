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
            try
            {
                System.Threading.Thread.Sleep(2500); // 2.5 seconds should be plenty of time for the caller to shut down

                string strSource = args[0];
                string strDestination = args[1];



                System.Threading.Thread.Sleep(1500);

                System.IO.File.WriteAllText("D:\\output.txt", "Source: " + strSource + " ~~~ Destination: " + strDestination);

                System.Diagnostics.Process.Start(strDestination);

                System.IO.File.AppendAllText("D:\\output.txt", "Launched: " + strDestination);

            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("D:\\output.txt", "Error: " + ex.Message);
                Console.WriteLine("There was an error: " + ex.Message);
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();
            }

            

        }
    }
}
