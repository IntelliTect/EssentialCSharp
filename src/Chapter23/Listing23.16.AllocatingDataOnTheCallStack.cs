namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_16
{
    public static class Program
    {
        #region INCLUDE
        public static void Main()
        {
            unsafe
            {
                // ...
                byte* bytes = stackalloc byte[42];
                // ...
            }
        }
        #endregion INCLUDE
    }
}