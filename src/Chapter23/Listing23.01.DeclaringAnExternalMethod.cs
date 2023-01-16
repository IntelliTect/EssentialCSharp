namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_01;

#region INCLUDE
using System;
using System.Runtime.InteropServices;
public class VirtualMemoryManager
{
    [DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
    #region HIGHLIGHT
    internal static extern IntPtr GetCurrentProcessHandle();
    #endregion HIGHLIGHT
}
#endregion INCLUDE
