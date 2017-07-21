namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter08.Listing08_08
{
    using System;

    class Program
    {
        static void Main()
        {
            int number;
            object thing;
            number = 42;
            // Boxing
            thing = number;
            // No unboxing conversion.
            string text = ((IFormattable)thing).ToString(
                "X", null);
            Console.WriteLine(text);
        }
    }
}