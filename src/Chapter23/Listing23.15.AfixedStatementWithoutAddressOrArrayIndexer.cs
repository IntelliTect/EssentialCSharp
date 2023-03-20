namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_15;

public unsafe class FixedState
{
    public static void Main()
    {
        #region INCLUDE
        byte[] bytes = new byte[24];
        fixed (byte* pData = bytes)
        {
            // ...
        }
        #endregion INCLUDE
    }
}