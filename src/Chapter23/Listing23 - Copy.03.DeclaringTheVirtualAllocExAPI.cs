namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_03
{
    #region INCLUDE
    public class VirtualMemoryManager
    {
        // ...
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool VirtualProtectEx(
            IntPtr hProcess, IntPtr lpAddress,
            IntPtr dwSize, uint flNewProtect,
        #region HIGHLIGHT
            ref uint lpflOldProtect);
        #endregion HIGHLIGHT
    }
    #endregion INCLUDE
}