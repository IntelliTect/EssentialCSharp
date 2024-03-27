namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_02
{
    #region INCLUDE
    LPVOID VirtualAllocEx(
        HANDLE hProcess,        // The handle to a process. The
                                // function allocates memory within
                                // the virtual address space of this
                                // process.
        LPVOID lpAddress,       // The pointer that specifies a
                                // desired starting address for the
                                // region of pages that you want to
                                // allocate. If lpAddress is NULL,
                                // the function determines where to
                                // allocate the region.
        SIZE_T dwSize,          // The size of the region of memory to
                                // allocate, in bytes. If lpAddress
                                // is NULL, the function rounds dwSize
                                // up to the next page boundary.
        DWORD flAllocationType, // The type of memory allocation
        DWORD flProtect);       // The type of memory protection
    #endregion INCLUDE
}