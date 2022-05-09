// Justification: Use to demonstrate pre-C# 8.0 syntax.
#pragma warning disable IDE0063 // Use simple 'using' statement

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_22
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_21;

    #region INCLUDE
    public static class Program
    {
        public static void Search()
        {
            #region HIGHLIGHT
            // C# 8.0
            using TemporaryFileStream fileStream1 =
                new TemporaryFileStream();
            #endregion HIGHLIGHT

            #region HIGHLIGHT
            // Prior to C# 8.0
            using (TemporaryFileStream fileStream2 =
                new TemporaryFileStream(),
                fileStream3 = new TemporaryFileStream())
            #endregion HIGHLIGHT
            {
                // Use temporary file stream;
            }
        }
    }
    #endregion INCLUDE
}