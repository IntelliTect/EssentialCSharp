namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_06;

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
                ["Information"] = ConsoleColor.Green
            };

        #region HIGHLIGHT
        colorMap["Verbose"] = ConsoleColor.White;
        colorMap["Error"] = ConsoleColor.Cyan;
        #endregion HIGHLIGHT

        #region EXCLUDE
        Print(colorMap);
    }

    private static void Print(IEnumerable<KeyValuePair<string, ConsoleColor>> items)
    {
        foreach (KeyValuePair<string, ConsoleColor> item in items)
        {
            Console.ForegroundColor = item.Value;
            Console.WriteLine(item.Key);
        }
        #endregion EXCLUDE
    }
}
#endregion INCLUDE
