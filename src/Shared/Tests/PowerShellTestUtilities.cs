using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests
{
    public class PowerShellTestUtilities
    {
        public static bool WindowsEnvironment()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        }


        public static Lazy<string?> _PowerShellCommand = new Lazy<string?>(() =>
        {
            string? powershellCommand = null;
            // Verify that the PowerShell command executes successfully.
            foreach(string command in 
                new string[]{ "pwsh", WindowsEnvironment() ? "powershell" : null!}.Where(item=> item is not null))
            {
                try
                {
                    Process powershell = Process.Start(command, "-h");
                    powershell.WaitForExit();
                    if (powershell.ExitCode == 0)
                    {
                        powershellCommand = command;
                        break;
                    }
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    powershellCommand = null;
                }
            }
            return powershellCommand;
        });
        public static int RunPowerShellScript(string scriptPath, string arguments) =>
            RunPowerShellScript(scriptPath, arguments, out string psOutput);

        public static int RunPowerShellScript(string scriptPath, string arguments, out string psOutput)
        {
            if(PowerShellCommand is null)
            {
                throw new InvalidOperationException("PowerShell is not installed");
            }

            if(!System.IO.File.Exists(scriptPath))
            {
                throw new InvalidOperationException($"scriptPath, '{scriptPath}', not found.");
            }

            using var powerShell = new Process();
            powerShell.StartInfo.RedirectStandardOutput = true;
            powerShell.StartInfo.FileName = PowerShellCommand;
            powerShell.StartInfo.Arguments = $"-noprofile -command \"{scriptPath} {arguments}\"";
            powerShell.Start();
            psOutput = powerShell.StandardOutput.ReadToEnd();
            powerShell.WaitForExit();

            return powerShell.ExitCode;
        }

        public static string? PowerShellCommand => _PowerShellCommand!.Value;
        public static bool PowerShellNotInstalled =>_PowerShellCommand.Value == null;
    }
}
