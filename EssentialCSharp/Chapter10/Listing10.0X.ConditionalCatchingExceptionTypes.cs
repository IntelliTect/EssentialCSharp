namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_0X
{
    using System;
    using System.ComponentModel;

    public sealed class Program
    {
        public static void Main()
        {
            try
            {
                // ...
                throw new InvalidOperationException(
                    "Arbitrary exception");
                // ...
            }
            catch(Win32Exception exception) when(exception.ErrorCode == 42)
            {
                // Handle NullReferenceException
            }
        }
    }
}