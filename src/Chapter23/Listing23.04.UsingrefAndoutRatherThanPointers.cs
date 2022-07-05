namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_04
{
    #region INCLUDE
    using System;
    using System.Runtime.InteropServices;
    public class VirtualMemoryManager
    {
        [DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
        internal static extern IntPtr GetCurrentProcessHandle();
    }
    #endregion INCLUDE
}