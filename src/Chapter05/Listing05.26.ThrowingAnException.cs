#pragma warning disable CS1058
#pragma warning disable CS0168 // Variable is declared but never used
#pragma warning disable CS0162 // Unreachable code detected
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_26
{
    #region INCLUDE
    // A previous catch clause already catches all exceptions
    using System;

    public class ThrowingExceptions
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Begin executing");
                Console.WriteLine("Throw exception");
                #region HIGHLIGHT
                throw new Exception("Arbitrary exception");
                #endregion HIGHLIGHT
                Console.WriteLine("End executing");
                }
            catch(FormatException exception)
            {
                Console.WriteLine(
                    "A FormatException was thrown");
            }
            catch(Exception exception)
            {
                Console.WriteLine(
                    $"Unexpected error: { exception.Message }");
            }
            catch
            {
                Console.WriteLine("Unexpected error!");
            }

            Console.WriteLine(
                "Shutting down...");
        }
    }
    #endregion INCLUDE
}
