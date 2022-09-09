using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

namespace Chapter10.Tests.PowerShellTestsUtilities
{
    class PowerShellTestsUtilities
    {
        public static bool WindowsEnvironment()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        }


        public static Lazy<string?> _PowerShellCommand = new Lazy<string?>(() =>
        {
            string? powershellCommand = WindowsEnvironment() ? "powershell" : null;

            IEnumerable<string>? environmentVariables = Environment.GetEnvironmentVariables().Values.Cast<string>();

            if(environmentVariables.Any(item => item.ToLowerInvariant().Contains("pwsh")))
            {
                powershellCommand = "pwsh";
            }

            if (powershellCommand is not null)
            {
                // Verify that the PowerShell command executes successfully.
                try
                {
                    Process powershell = Process.Start(powershellCommand, "-h");
                    powershell.WaitForExit();
                    var exitCode = powershell.ExitCode;
                    if (exitCode != 0)
                    {
                        powershellCommand = null;
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
