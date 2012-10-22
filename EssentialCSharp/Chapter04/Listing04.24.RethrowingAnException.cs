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
            catch (FormatException exception)
            {

            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    "Rethrowing unexpected error:  {0}",
                    exception.Message);
                throw;
            }

            Console.WriteLine("Shutting down...");
        }
    }
}
