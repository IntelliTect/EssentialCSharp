using System;
using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_06
{
    #region INCLUDE
    public class VirtualMemoryManager
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr VirtualAllocEx(
            IntPtr hProcess,
            IntPtr lpAddress,
            IntPtr dwSize,
            AllocationType flAllocationType,
            uint flProtect);

        // ...
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool VirtualProtectEx(
            IntPtr hProcess, IntPtr lpAddress,
            IntPtr dwSize, uint flNewProtect,
        #region HIGHLIGHT
            ref uint lpflOldProtect);
        #endregion HIGHLIGHT

        [Flags]
        private enum AllocationType : uint
        {
            #region EXCLUDE
            Reserve,
            Commit
            #endregion EXCLUDE
        }

        [Flags]
        private enum ProtectionOptions
        {
            #region EXCLUDE
            PageExecuteReadWrite
            #endregion EXCLUDE
        }

        [Flags]
        private enum MemoryFreeType
        {
            // ...
        }

        public static IntPtr AllocExecutionBlock(
            int size, IntPtr hProcess)
        {
            IntPtr codeBytesPtr;
            codeBytesPtr = VirtualAllocEx(
                hProcess, IntPtr.Zero,
                (IntPtr)size,
                AllocationType.Reserve | AllocationType.Commit,
                (uint)ProtectionOptions.PageExecuteReadWrite);

            if (codeBytesPtr == IntPtr.Zero)
            {
                #region HIGHLIGHT
                throw new System.ComponentModel.Win32Exception();
                #endregion HIGHLIGHT
            }

            uint lpflOldProtect = 0;
            if (!VirtualProtectEx(
                hProcess, codeBytesPtr,
                (IntPtr)size,
                (uint)ProtectionOptions.PageExecuteReadWrite,
                ref lpflOldProtect))
            {
                #region HIGHLIGHT
                throw new System.ComponentModel.Win32Exception();
                #endregion HIGHLIGHT
            }
            return codeBytesPtr;
        }

        public static IntPtr AllocExecutionBlock(int size)
        {
            return AllocExecutionBlock(
                size, GetCurrentProcessHandle());
        }
        
        #region EXCLUDE
        public static IntPtr GetCurrentProcessHandle()
        {
            throw new NotImplementedException();
        }
        #endregion EXCLUDE
    }
    #endregion INCLUDE
}