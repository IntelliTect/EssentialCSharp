namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_02;

#region INCLUDE
using System;
using System.Collections.Generic;
#region EXCLUDE
public class Program
{
    public static void Main()
    {
        #endregion EXCLUDE
#if !PRECSHARP6
        Dictionary<string, ConsoleColor> colorMap = new()
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
        #endregion INCLUDE

        Print(colorMap);
    } 

    private static void Print(IEnumerable<KeyValuePair<string, ConsoleColor>> items)
    {
        foreach(KeyValuePair<string, ConsoleColor> item in items)
        {
            Console.ForegroundColor = item.Value;
            Console.WriteLine(item.Key);
        }
    }
}
