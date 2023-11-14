using static AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_06.VirtualMemoryManager;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_03
{
    #region INCLUDE
    using System;
    using System.Runtime.InteropServices;

    public class VirtualMemoryManager
    {
        [DllImport("kernel32.dll")]
        internal static extern IntPtr GetCurrentProcess();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr VirtualAllocEx(
            IntPtr hProcess,
            IntPtr lpAddress,
            IntPtr dwSize,
            AllocationType flAllocationType,
            uint flProtect);
    }
    #endregion INCLUDE
}