namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_15
{
    public class FixedState
    {
        #region INCLUDE
        byte[] bytes = new byte[24];
        fixed (byte * pData = bytes) 
        {
          // ...
        }
    #endregion INCLUDE
    }
}