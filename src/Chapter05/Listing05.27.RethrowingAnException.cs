namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_24
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
            catch(FormatException exception)
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
