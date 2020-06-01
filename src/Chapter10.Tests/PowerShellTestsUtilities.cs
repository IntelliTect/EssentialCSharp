using System;
using System.Runtime.InteropServices;

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

            foreach (string? value in environmentVariables)
            {
                if (!string.IsNullOrEmpty(value) && (value.ToLowerInvariant().Contains("powershell") || value.ToLowerInvariant().Contains("pwsh")))
                {
                    return false;
                }
            }
            return true;
        }

  
    }
}
