namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_07a
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
#if !PRECSHARP5
            var colorMap = new SortedDictionary<string, ConsoleColor>
                {
                    ["Error"] = ConsoleColor.Red,
                    ["Warning"] = ConsoleColor.Yellow,
                    ["Information"] = ConsoleColor.Green,
                    ["Verbose"] = ConsoleColor.White
                };
#else
            Dictionary<string, ConsoleColor> colorMap =
                new Dictionary<string, ConsoleColor>
                {
                    {"Error", ConsoleColor.Red },
                    {"Warning", ConsoleColor.Yellow },
                    {"Information", ConsoleColor.Green },
                    {"Verbose", ConsoleColor.White}
                };
#endif

            Print(colorMap);
      }

      private static void Print(
          IEnumerable<KeyValuePair<string, ConsoleColor>> items)
      {
          foreach (KeyValuePair<string, ConsoleColor> item in items)
          {
              Console.ForegroundColor = item.Value;
              Console.WriteLine(item.Key);
          }
        }
    }
}