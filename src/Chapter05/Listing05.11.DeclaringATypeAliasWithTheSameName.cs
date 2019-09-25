#pragma warning disable CS0168 // Variable is declared but never used
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_11
{
    // Declare alias Console to refer to SubListing04_09.Console to 
    // avoid code ambiguity with System.Console
    using Console = SubListing_04_09.Console;

    public class HelloWorld
    {
        public static void Main()
        {
            Console console;

            // ...
        }
    }
}

namespace SubListing_04_09
{
    public class Console
    {
        public void Write(string message)
        {

        }
    }
}
