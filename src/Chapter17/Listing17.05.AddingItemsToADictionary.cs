namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_05
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
#if !PRECSHARP5
        // C# 6.0
        Dictionary<string, ConsoleColor> colorMap =
            new Dictionary<string, ConsoleColor>
            {
                ["Error"] = ConsoleColor.Red,
                ["Warning"] = ConsoleColor.Yellow,
                ["Information"] = ConsoleColor.Green
            };
#else
        // Pre-C# 6.0
        Dictionary<string, ConsoleColor> colorMap =
            new Dictionary<string, ConsoleColor>
            {
                {"Error", ConsoleColor.Red },
                {"Warning", ConsoleColor.Yellow },
                {"Information", ConsoleColor.Green }
            };
#endif

            colorMap.Add("Verbose", ConsoleColor.White);

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
