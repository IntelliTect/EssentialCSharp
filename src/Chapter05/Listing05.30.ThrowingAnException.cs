#pragma warning disable CS1058
#pragma warning disable CS0168 // Variable is declared but never used
#pragma warning disable CS0162 // Unreachable code detected
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_30;

public class ThrowingExceptions
{
    // A previous catch clause already catches all exceptions
    #region INCLUDE
    public static void Main()
    {
        try
        {
            Console.WriteLine("Begin executing");
            Console.WriteLine("Throw exception");
            #region HIGHLIGHT
            throw new Exception("Arbitrary exception");
            // Catch 1
            #endregion HIGHLIGHT
            Console.WriteLine("End executing");
        }
        catch(FormatException exception)
        {
            Console.WriteLine(
                "A FormatException was thrown");
        }
        // Catch 1
        catch(Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error: { exception.Message }");
            // Jump to Post Catch
        }

        // Post Catch
        Console.WriteLine(
            "Shutting down...");
    }
    #endregion INCLUDE
}
