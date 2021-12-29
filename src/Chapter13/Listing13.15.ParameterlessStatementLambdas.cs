// TODO: Update listing in Manuscript
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_15
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Func<string> getUserInput =
                () =>
                {
                    string? input;
                    do
                    {
                        input = Console.ReadLine();
                    }
                    while(!string.IsNullOrEmpty(input));
                    return input!;
                };
            getUserInput();
        }
    }
}