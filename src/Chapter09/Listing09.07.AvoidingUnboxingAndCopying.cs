namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_07
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number;
            object thing;
            number = 42;
            // Boxing
            thing = number;
            // No unboxing conversion
            string text = ((IFormattable)thing).ToString(
                "X", null);
            Console.WriteLine(text);
        }
    }
}
