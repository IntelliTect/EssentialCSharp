namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_14
{
    public class FixedState
    {
        #region INCLUDE
        byte[] bytes = new byte[24];
        (byte* pData = bytes)
        {
          // ...
        }
        #endregion INCLUDE
    }
}