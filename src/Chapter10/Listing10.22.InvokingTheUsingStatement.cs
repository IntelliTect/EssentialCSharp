// Justification: Use to demonstrate pre-C# 8.0 syntax.
#pragma warning disable IDE0063 // Use simple 'using' statement

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_22
{
    using AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_21;

    public static class Program
    {
        public static void Search()
        {
            // C# 8.0
            using TemporaryFileStream fileStream1 =
                new TemporaryFileStream();

            // Prior to C# 8.0
            using (TemporaryFileStream fileStream2 =
                new TemporaryFileStream(),
                fileStream3 = new TemporaryFileStream())
            {
                // Use temporary file stream;
            }
        }
    }

}