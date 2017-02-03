namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_09
{
    // Declare alias Console to refer to SubListing04_09.Console to 
    // avoid code ambiguity with System.Console
    using Console = SubListing_04_09.Console;

    public class HelloWorld
    {
        public static void ChapterMain()
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
