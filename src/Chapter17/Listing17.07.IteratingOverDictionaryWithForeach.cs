namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_07;

#region INCLUDE
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        var colorMap = new Dictionary<string, ConsoleColor>
            {
                ["Error"] = ConsoleColor.Red,
                ["Warning"] = ConsoleColor.Yellow,
                ["Information"] = ConsoleColor.Green,
                ["Verbose"] = ConsoleColor.White
            };

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
