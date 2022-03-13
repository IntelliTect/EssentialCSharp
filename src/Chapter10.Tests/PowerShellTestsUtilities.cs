using System;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Chapter10.Tests.PowerShellTestsUtilities
{
    class PowerShellTestsUtilities
    {
        public static bool WindowsEnvironment()
        {
            return RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
        }

        public static bool PowerShellNotInstalled()
        {
            var environmentVariables = Environment.GetEnvironmentVariables().Values;
            bool result = true;
            foreach (string? value in environmentVariables)
            {
                if (!string.IsNullOrEmpty(value) && (value.ToLowerInvariant().Contains("powershell") || value.ToLowerInvariant().Contains("pwsh")))
                {
                    result = false;
                }
            }
            if (result == true)
            {
                string PowershellEnvironmentVariableName  = "powershell";
                if (!PowerShellTestsUtilities.WindowsEnvironment()) PowershellEnvironmentVariableName = "pwsh";
                try
                {
                    Process powershell = Process.Start(PowershellEnvironmentVariableName, "--version");
                    powershell.WaitForExit();
                    var exitCode = powershell.ExitCode;
                    if(exitCode == 0)
                    {
                        result = false;
                    }
                }
                catch(System.ComponentModel.Win32Exception)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
