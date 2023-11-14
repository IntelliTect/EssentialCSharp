using System.Runtime.InteropServices;
using static AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_06.VirtualMemoryManager;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_09
{
    #region INCLUDE
    public class VirtualMemoryManager
    {
        // ...

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool VirtualFreeEx(
            IntPtr hProcess, IntPtr lpAddress,
            IntPtr dwSize, IntPtr dwFreeType);
        public static bool VirtualFreeEx(
            IntPtr hProcess, IntPtr lpAddress,
            IntPtr dwSize)
        {
            bool result = VirtualFreeEx(
                hProcess, lpAddress, dwSize,
                (IntPtr)MemoryFreeType.Decommit);
            if (!result)
            {
                throw new System.ComponentModel.Win32Exception();
            }
            return result;
        }
        public static bool VirtualFreeEx(
            IntPtr lpAddress, IntPtr dwSize)
        {
            return VirtualFreeEx(
                GetCurrentProcessHandle(), lpAddress, dwSize);
        }

        [DllImport("kernel32", SetLastError = true)]
        static extern IntPtr VirtualAllocEx(
            IntPtr hProcess,
            IntPtr lpAddress,
            IntPtr dwSize,
            AllocationType flAllocationType,
            uint flProtect);

        // ...
    }
    #endregion INCLUDE
}