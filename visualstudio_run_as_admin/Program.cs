using System;
using System.Diagnostics;

namespace visualstudio_run_as_admin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
                return;

            string slnPath = args[0];

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\devenv.exe",
                Arguments = "\"" + slnPath + "\"",
                Verb = "runas",
                UseShellExecute = true
            };

            Process.Start(psi);
        }
    }
}