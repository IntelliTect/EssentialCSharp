namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_07
{
    // The using directive imports all types from the 
    // specified namespace into the entire file
    using System;

    public class HelloWorld
    {
        public static void Main()
        {
            // No need to qualify Console with System
            // because of the using directive above
            Console.WriteLine("Hello, my name is Inigo Montoya");
        }
    }
}
