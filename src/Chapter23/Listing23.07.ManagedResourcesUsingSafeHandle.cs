using AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_06;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_07
{
    #region INCLUDE
    public class VirtualMemoryPtr :
      System.Runtime.InteropServices.SafeHandle
    {
        public VirtualMemoryPtr(int memorySize) :
            base(IntPtr.Zero, true)
        {
            _ProcessHandle =
                VirtualMemoryManager.GetCurrentProcessHandle();
            _MemorySize = (IntPtr)memorySize;
            _AllocatedPointer =
                VirtualMemoryManager.AllocExecutionBlock(
                memorySize, _ProcessHandle);
            _Disposed = false;
        }

        public readonly IntPtr _AllocatedPointer;
        private readonly IntPtr _ProcessHandle;
        private readonly IntPtr _MemorySize;
        private bool _Disposed;

        public static implicit operator IntPtr(
            VirtualMemoryPtr virtualMemoryPointer)
        {
            return virtualMemoryPointer._AllocatedPointer;
        }

        // SafeHandle abstract member
        public override bool IsInvalid
        {
            get
            {
                return _Disposed;
            }
        }

        // SafeHandle abstract member
        protected override bool ReleaseHandle()
        {
            if (!_Disposed)
            {
                _Disposed = true;
                GC.SuppressFinalize(this);
                VirtualMemoryManager.VirtualFreeEx(_ProcessHandle,
                    _AllocatedPointer, _MemorySize);
            }
            return true;
        }
    }
    #endregion INCLUDE
}