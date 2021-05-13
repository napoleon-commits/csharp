using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ps1File = @"C:\testscripts\MyFirstScript.ps1";
            var startInfo = new ProcessStartInfo()
            {
                FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe",
                Arguments = $"-NoProfile -ExecutionPolicy Bypass -Command \"&'{ps1File}'\"",
                UseShellExecute = false
            };
            Process.Start(startInfo);
        }
    }
}
