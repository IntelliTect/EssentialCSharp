namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_07
{
    #region INCLUDE
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            #region EXCLUDE
#if !PRECSHARP5
            #endregion EXCLUDE
            Dictionary<string, ConsoleColor> colorMap =
                new Dictionary<string, ConsoleColor>
                {
                    ["Error"] = ConsoleColor.Red,
                    ["Warning"] = ConsoleColor.Yellow,
                    ["Information"] = ConsoleColor.Green,
                    ["Verbose"] = ConsoleColor.White
                };
            #region EXCLUDE
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
            #endregion EXCLUDE
            Print(colorMap);
      }

        #region HIGHLIGHT
        private static void Print(
          IEnumerable<KeyValuePair<string, ConsoleColor>> items)
        #endregion HIGHLIGHT
        {
            #region HIGHLIGHT
            foreach (KeyValuePair<string, ConsoleColor> item in items)
            #endregion HIGHLIGHT
            {
                Console.ForegroundColor = item.Value;
              Console.WriteLine(item.Key);
          }
        }
    }
#endregion INCLUDE
}