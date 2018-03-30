namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_06
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            // C# 6.0 (use {"Error", ConsoleColor.Red} pre-C# 6.0)
            Dictionary<string, ConsoleColor> colorMap =
                new Dictionary<string, ConsoleColor>
                {
                    ["Error"] = ConsoleColor.Red,
                    ["Warning"] = ConsoleColor.Yellow,
                    ["Information"] = ConsoleColor.Green
                };

            colorMap["Verbose"] = ConsoleColor.White;
            colorMap["Error"] = ConsoleColor.Cyan;

            Print(colorMap);
        }

        private static void Print(IEnumerable<KeyValuePair<string, ConsoleColor>> items)
        {
            foreach (KeyValuePair<string, ConsoleColor> item in items)
            {
                Console.ForegroundColor = item.Value;
                Console.WriteLine(item.Key);
            }
        }
    }
}