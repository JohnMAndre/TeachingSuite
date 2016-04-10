using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdaterReplacer
{
    class Program
    {
        static void Main()
        {
            // This will do one very simple task
            // If the Updater.exe.replacement is present, it will 
            // delete updater.exe and rename updater.exe.replacer to updater.exe
            // This should be on a delay to give time for the updater to close down
            string strSource, strDestination;
            strDestination=System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            strSource=System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            if(System.IO.File.Exists())
        }
    }
}
