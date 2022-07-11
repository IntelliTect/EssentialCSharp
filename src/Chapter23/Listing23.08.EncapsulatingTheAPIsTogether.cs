namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_08
{
    #region INCLUDE
    public class VirtualMemoryManager
    {
        // ...

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
        /// The type of free operation.
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

        // ...
    }
    #endregion INCLUDE
}