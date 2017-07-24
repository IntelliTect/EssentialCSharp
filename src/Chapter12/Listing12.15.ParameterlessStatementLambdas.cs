namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_14
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Func<string> getUserInput =
                () =>
                {
                    string input;
                    do
                    {
                        input = Console.ReadLine();
                    }
                    while(input.Trim().Length == 0);
                    return input;
                };
        }
    }
}