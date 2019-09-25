#pragma warning disable CS0162 // Unreachable code detected
#pragma warning disable CS1058 // A previous catch clause already catches all exceptions
#pragma warning disable CS0168 // Variable is declared but never used
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_27
{
    using System;

    public class ThrowingExceptions
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Begin executing");
                Console.WriteLine("Throw exception");
                throw new Exception("Arbitrary exception");
                Console.WriteLine("End executing");
            }
            catch (FormatException exception)
            {
                Console.WriteLine(
                    "A FormateException was thrown");
            }
            catch(Exception exception)
            {
                Console.WriteLine(
                    "Rethrowing unexpected error:  "
                    + $"{ exception.Message }");

                throw;
            }
            catch
            {
                Console.WriteLine("Unexpected error!");
            }

            Console.WriteLine(
                "Shutting down...");
        }
    }
}
