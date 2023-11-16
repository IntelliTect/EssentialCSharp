using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_05
{
    #region INCLUDE
    #region HIGHLIGHT
    [StructLayout(LayoutKind.Sequential)]
    #endregion HIGHLIGHT
    struct ColorRef
    {
        public byte Red;
        public byte Green;
        public byte Blue;
        // Turn off the warning about not accessing Unused
#pragma warning disable 414
        private byte Unused;
#pragma warning restore 414

        public ColorRef(byte red, byte green, byte blue)
        {
            Blue = blue;
            Green = green;
            Red = red;
            Unused = 0;
        }
    }
    #endregion INCLUDE
}