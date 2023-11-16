namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_14
{
    public class FixedState
    {
        #region INCLUDE
        public void Main()
        {
            unsafe
            {
                // ...
                byte[] bytes = new byte[24];
                fixed (byte* pData = &bytes[0]) //pData = bytes also allowed
                {
                    // ...
                }
                // ...
            }
        }
        #endregion INCLUDE
    }
}