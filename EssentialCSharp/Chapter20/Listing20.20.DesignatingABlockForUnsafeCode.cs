namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_20
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Runtime.InteropServices;

    class Program
    {
        public unsafe static int Main()
        {
            // Assign redpill 
            byte[] redpill = { 
          0x0f, 0x01, 0x0d,       // asm SIDT instruction
          0x00, 0x00, 0x00, 0x00, // placeholder for an address
          0xc3};                  // asm return instruction

            unsafe
            {
                fixed (byte* matrix = new byte[6],
                    redpillPtr = redpill)
                {
                    // Move the address of matrix immediately 
                    // following the SIDT instruction of memory.
                    *(uint*)&redpillPtr[3] = (uint)&matrix[0];

                    using (VirtualMemoryPtr codeBytesPtr =
                        new VirtualMemoryPtr(redpill.Length))
                    {
                        Marshal.Copy(
                            redpill, 0,
                            codeBytesPtr, redpill.Length);

                        MethodInvoker method =
                            (MethodInvoker)Marshal.GetDelegateForFunctionPointer(
                            codeBytesPtr, typeof(MethodInvoker));

                        method();
                    }
                    if (matrix[5] > 0xd0)
                    {
                        Console.WriteLine("Inside Matrix!\n");
                        return 1;
                    }
                    else
                    {
                        Console.WriteLine("Not in Matrix.\n");
                        return 0;
                    }
                } // fixed
            } // unsafe
        }
    }
    
    public class VirtualMemoryPtr : System.Runtime.InteropServices.SafeHandle
    {
        public VirtualMemoryPtr(int memorySize) :
            base(IntPtr.Zero, true)
        {
            ProcessHandle =
                VirtualMemoryManager.GetCurrentProcessHandle();
            MemorySize = (IntPtr)memorySize;
            AllocatedPointer =
                VirtualMemoryManager.AllocExecutionBlock(
                memorySize, ProcessHandle);
            Disposed = false;
        }

        public readonly IntPtr AllocatedPointer;
        readonly IntPtr ProcessHandle;
        readonly IntPtr MemorySize;
        bool Disposed;

        public static implicit operator IntPtr(
            VirtualMemoryPtr virtualMemoryPointer)
        {
            return virtualMemoryPointer.AllocatedPointer;
        }

        // SafeHandle abstract member
        public override bool IsInvalid
        {
            get
            {
                return Disposed;
            }
        }

        // SafeHandle abstract member
        protected override bool ReleaseHandle()
        {
            if (!Disposed)
            {
                Disposed = true;
                GC.SuppressFinalize(this);
                VirtualMemoryManager.VirtualFreeEx(ProcessHandle,
                    AllocatedPointer, MemorySize);
            }
            return true;
        }
    }

    class VirtualMemoryManager
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr VirtualAllocEx(
            IntPtr hProcess,
            IntPtr lpAddress,
            IntPtr dwSize, 
            AllocationType flAllocationType,
            uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool VirtualProtectEx(
            IntPtr hProcess, IntPtr lpAddress,
            IntPtr dwSize, uint flNewProtect,
            ref uint lpflOldProtect);

        [DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
        internal static extern IntPtr GetCurrentProcessHandle();

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



        /// <summary>
        /// The type of memory allocation. This parameter must
        /// contain one of the following values.
        /// </summary>
        [Flags]
        private enum AllocationType : uint
        {
            /// <summary>
            /// Allocates physical storage in memory or in the
            /// paging file on disk for the specified reserved
            /// memory pages. The function initializes the memory
            /// to zero.
            /// </summary>

            Commit = 0x1000,
            /// <summary>
            /// Reserves a range of the process's virtual address
            /// space without allocating any actual physical
            /// storage in memory or in the paging file on disk.
            /// </summary>
            Reserve = 0x2000,
            /// <summary>
            /// Indicates that data in the memory range specified by
            /// lpAddress and dwSize is no longer of interest. The
            /// pages should not be read from or written to the
            /// paging file. However, the memory block will be used
            /// again later, so it should not be decommitted. This
            /// value cannot be used with any other value.
            /// </summary>
            Reset = 0x80000,
            /// <summary>
            /// Allocates physical memory with read-write access.
            /// This value is solely for use with Address Windowing
            /// Extensions (AWE) memory.
            /// </summary>
            Physical = 0x400000,
            /// <summary>
            /// Allocates memory at the highest possible address.
            /// </summary>
            TopDown = 0x100000,
        }

        /// <summary>
        /// The memory protection for the region of pages to be
        /// allocated.
        /// </summary>
        [Flags]
        private enum ProtectionOptions : uint
        {
            /// <summary>
            /// Enables execute access to the committed region of
            /// pages. An attempt to read or write to the committed
            /// region results in an access violation.
            /// </summary>
            Execute = 0x10,
            /// <summary>
            /// Enables execute and read access to the committed
            /// region of pages. An attempt to write to the
            /// committed region results in an access violation.
            /// </summary>
            PageExecuteRead = 0x20,
            /// <summary>
            /// Enables execute, read, and write access to the
            /// committed region of pages.

            /// </summary>
            PageExecuteReadWrite = 0x40,
            // ...
        }

        /// <summary>
        /// The type of free operation
        /// </summary>
        [Flags]
        private enum MemoryFreeType : uint
        {
            /// <summary>
            /// Decommits the specified region of committed pages.
            /// After the operation, the pages are in the reserved
            /// state.
            /// </summary>
            Decommit = 0x4000,
            /// <summary>
            /// Releases the specified region of pages. After this
            /// operation, the pages are in the free state.
            /// </summary>
            Release = 0x8000
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
                throw new System.ComponentModel.Win32Exception();
            }

            uint lpflOldProtect = 0;
            if (!VirtualProtectEx(
                hProcess, codeBytesPtr,
                (IntPtr)size,
                (uint)ProtectionOptions.PageExecuteReadWrite,
                ref lpflOldProtect))
            {
                throw new System.ComponentModel.Win32Exception();
            }
            return codeBytesPtr;
        }

        public static IntPtr AllocExecutionBlock(int size)
        {
            return AllocExecutionBlock(
                size, GetCurrentProcessHandle());
        }
    }
}